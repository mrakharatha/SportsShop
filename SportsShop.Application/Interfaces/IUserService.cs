using System.Collections.Generic;
using SportsShop.Domain.Models.User;
using SportsShop.Domain.ViewModels.Account;
using SportsShop.Domain.ViewModels.User;

namespace SportsShop.Application.Interfaces
{
    public   interface IUserService
 {
  
     List<User> GetAllUsers();
     
     bool IsExistUserName(string userName);
     int AddUserViewModel(CreateUserViewModel user);
  
     
     int AddUser(User user);
  
     EditUserViewModel GetUserViewModelByUserId(int userId);
   
     void EditUserViewModel(EditUserViewModel user);
     
     void UpdateUser(User user);

     User GetUserByUserId(int userId);
  
     User LoginUser(LoginViewModel login);
       
     bool CompareOldPassword(int userId, string oldPassword);
      
     void ChangeUserPassword(int userId, string newPassword);
       
     void DeleteUser(int userId);
      
     User GetUserByUserName(string username);
 }
}
