using System.Collections.Generic;
using SportsShop.Domain.Models.User;
using SportsShop.Domain.ViewModels.Account;
using SportsShop.Domain.ViewModels.User;

namespace SportsShop.Domain.Interfaces
{
    
  public  interface IUserRepository
    {
      
        List<User> GetAllUsers();
        bool IsExistUserName(string userName);
        int AddUser(User user);
        EditUserViewModel GetUserViewModelByUserId(int userId);
        void UpdateUser(User user);
        User GetUserByUserId(int userId);
        User LoginUser(LoginViewModel login);
        bool CompareOldPassword(int userId, string oldPassword);
        User GetUserByUserName(string username);
      

    }
}
