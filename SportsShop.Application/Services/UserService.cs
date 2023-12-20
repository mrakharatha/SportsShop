using System;
using System.Collections.Generic;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.User;
using SportsShop.Domain.Security;
using SportsShop.Domain.ViewModels.Account;
using SportsShop.Domain.ViewModels.User;

namespace SportsShop.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IPermissionService _permissionService;

        public UserService(IUserRepository userRepository, IPermissionService permissionService)
        {
            _userRepository = userRepository;
            _permissionService = permissionService;
        }
      

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public bool IsExistUserName(string userName)
        {
            return _userRepository.IsExistUserName(userName.Trim());
        }
        public int AddUserViewModel(CreateUserViewModel user)
        {
            var users = new User()
            {
                UserName = user.UserName.Trim(),
                FullName = user.FullName,
                Password = PasswordHelper.EncodePasswordMd5(user.Password),
                RoleId = user.RoleId
            };

            int userId= AddUser(users);


            return userId;
        }

       

        public int AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }

        public EditUserViewModel GetUserViewModelByUserId(int userId)
        {
            return _userRepository.GetUserViewModelByUserId(userId);
        }

        public void EditUserViewModel(EditUserViewModel user)
        {
            User users = GetUserByUserId(user.UserId);
            if (!string.IsNullOrEmpty(user.Password))
                users.Password = PasswordHelper.EncodePasswordMd5(user.Password);

            users.FullName = user.FullName;
            users.RoleId = user.RoleId;

            UpdateUser(users);
        }

        public void UpdateUser(User user)
        {
           user.UpdateDate=DateTime.Now;
           _userRepository.UpdateUser(user);
        }

        public User GetUserByUserId(int userId)
        {
            return _userRepository.GetUserByUserId(userId);
        }

        public User LoginUser(LoginViewModel login)
        {
            login.Password = PasswordHelper.EncodePasswordMd5(login.Password);
            login.UserName = login.UserName.Trim();
            return _userRepository.LoginUser(login);
        }

        public bool CompareOldPassword(int userId, string oldPassword)
        {
            string password = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _userRepository.CompareOldPassword(userId, password);
        }

        public void ChangeUserPassword(int userId, string newPassword)
        {
            string password = PasswordHelper.EncodePasswordMd5(newPassword);
            var user = GetUserByUserId(userId);
            user.Password = password;
            UpdateUser(user);
        }

        public void DeleteUser(int userId)
        {
            User user = GetUserByUserId(userId);
            user.DeleteDate = DateTime.Now;
            UpdateUser(user);
        }

        public User GetUserByUserName(string username)
        {
            return _userRepository.GetUserByUserName(username.Trim());
        }
        
    }
}
