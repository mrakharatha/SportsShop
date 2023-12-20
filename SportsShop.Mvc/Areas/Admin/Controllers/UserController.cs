using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Security;
using SportsShop.Domain.ViewModels.User;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{

    public class UserController : BaseController
    {
        private readonly IUserService _userService;
        private readonly IPermissionService _permissionService;

        public UserController(IUserService userService, IPermissionService permissionService)
        {
            _userService = userService;
            _permissionService = permissionService;
        }



        public IActionResult Index()
        {
            return View(_userService.GetAllUsers());
        }

        public IActionResult UserCreate()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UserCreate(CreateUserViewModel user)
        {
            if (!ModelState.IsValid)
            {
    
                return View(user);
            }

            if (_userService.IsExistUserName(user.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نمی باشد");
    
                return View(user);
            } 
            _userService.AddUserViewModel(user);


            return RedirectToAction("Index");
        }
        public IActionResult UserEdit(int id)
        {

            return View(_userService.GetUserViewModelByUserId(id));
        }

        [HttpPost]
        public IActionResult UserEdit(EditUserViewModel user)
        {
            if (!ModelState.IsValid)
            {
    
                return View(user);

            }

            _userService.EditUserViewModel(user);

            return RedirectToAction("Index");
        }




        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(14, User.GetUserId()))
                return     new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _userService.DeleteUser(id);
        }



    }
}
