using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.User;
using SportsShop.Domain.ViewModels.Account;
using SportsShop.Domain.ViewModels.User;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
    public class UserRepository : IUserRepository
    {
                private readonly SportsShopDbContext _context;

        public UserRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<User> GetAllUsers()
        {
            return _context.Users.Where(c=> c.UserId!=1)
                .OrderByDescending(u => u.CreateDate)
                .ToList();
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }
    

        public int AddUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

      
        public EditUserViewModel GetUserViewModelByUserId(int userId)
        {
            return _context.Users
                .Where(u => u.UserId == userId)
                .Select(u => new EditUserViewModel()
                {
                    FullName = u.FullName,
                    UserId = u.UserId,
                    RoleId = u.RoleId,
                })
                .First();
        }

        public void UpdateUser(User user)
        {
            var oldUser = GetUserByUserId(user.UserId);
            _context.Entry(oldUser).CurrentValues.SetValues(user);
            _context.SaveChanges();
        }

        public User GetUserByUserId(int userId)
        {
            return _context.Users.Find(userId);
        }

        public User LoginUser(LoginViewModel login)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == login.UserName && u.Password == login.Password);
        }

        public bool CompareOldPassword(int userId, string oldPassword)
        {
            return _context.Users.Any(u => u.UserId == userId && u.Password == oldPassword);

        }

        public User GetUserByUserName(string username)
        {
            return _context.Users.First(u => u.UserName == username);
        }

        public bool CheckDelete(int userId)
        {
            return false;
        }
    }
}
