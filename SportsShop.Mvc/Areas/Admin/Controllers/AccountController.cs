using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Security;
using SportsShop.Domain.ViewModels.Account;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
             
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
    
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginViewModel login, string returnUrl = null)
        {
            if (!ModelState.IsValid)
                return View(login);

            var user = _userService.LoginUser(login);
            if (user != null)
            {

                var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserId.ToString()),
                        new Claim(ClaimTypes.Name,user.FullName),
                        new Claim(ClaimTypes.Role,"Admin"),
                        new Claim("FullName", user.FullName.ToString()),
                    };
                var identity = new ClaimsIdentity(claims, "Admin_Schema");
                var principal = new ClaimsPrincipal(identity);
                var properties = new AuthenticationProperties
                {
                    IsPersistent = login.RememberMe
                };
                HttpContext.SignInAsync("Admin_Schema", principal, properties);

                if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
                    return Redirect(returnUrl);
                
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }


            ModelState.AddModelError(nameof(login.UserName), "کاربری با مشخصات وارد شده یافت نشد");
            return View(login);
        }




        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("Admin_Schema");
            return RedirectToAction("Login", "Account", new { area = "Admin" });
        }


        #region ChangePassword


        [Authorize(Roles = "Admin", AuthenticationSchemes = "Admin_Schema")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin", AuthenticationSchemes = "Admin_Schema")]
        public IActionResult ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = _userService.CompareOldPassword(User.GetUserId(), model.OldPassword);

            if (!result)
            {
                ModelState.AddModelError(nameof(model.OldPassword), "پسورد فعلی اشتباه است");

                return View(model);
            }

            _userService.ChangeUserPassword( User.GetUserId(), model.Password);

            return RedirectToAction("Logout");

        }
        #endregion




    }
}
