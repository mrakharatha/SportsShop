using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
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


        [PermissionChecker(7)]

        public IActionResult Index()
        {
            return View(_userService.GetAllUsers());
        }


        [PermissionChecker(8)]

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateUserViewModel user)
        {
            if (!ModelState.IsValid)
                return View(user);
            

            if (_userService.IsExistUserName(user.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نمی باشد");

                return View(user);
            }
            _userService.AddUserViewModel(user);


            return RedirectToAction("Index");
        }

        [PermissionChecker(9)]
        public IActionResult Update(int id)
        {

            return View(_userService.GetUserViewModelByUserId(id));
        }

        [HttpPost]
        public IActionResult Update(EditUserViewModel user)
        {
            if (!ModelState.IsValid)
                return View(user);



            _userService.EditUserViewModel(user);

            return RedirectToAction("Index");
        }




        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(10, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _userService.DeleteUser(id);
        }



    }
}
