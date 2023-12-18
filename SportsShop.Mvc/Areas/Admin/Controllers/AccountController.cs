using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
       

        public AccountController()
        {
          
        }
    
        public IActionResult Login()
        {
            return View();
        }


      //  [HttpPost]
        //public ActionResult Login(LoginApplicantViewModel login, string returnUrl = null)
        //{
        //    if (!ModelState.IsValid)
        //        return View(login);

        //    var applicant = _applicantService.LoginApplicant(login);
        //    if (applicant != null)
        //    {

        //        var claims = new List<Claim>()
        //            {
        //                new Claim(ClaimTypes.NameIdentifier,applicant.ApplicantId.ToString()),
        //                new Claim(ClaimTypes.Name,applicant.ExclusiveCode),
        //                new Claim(ClaimTypes.Role,"applicant"),
        //                new Claim("FullName", applicant.ApplicantName.ToString()),
        //            };
        //        var identity = new ClaimsIdentity(claims, "Applicant_Schema");
        //        var principal = new ClaimsPrincipal(identity);
        //        var properties = new AuthenticationProperties
        //        {
        //            IsPersistent = login.RememberMe
        //        };
        //        HttpContext.SignInAsync("Applicant_Schema", principal, properties);


        //        return RedirectToAction("Index", "Home", new { area = "Admin" });

        //    }


        //    ModelState.AddModelError("ExclusiveCode", "کاربری با مشخصات وارد شده یافت نشد");
        //    return View(login);
        //}




        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("Admin_Schema");
            return RedirectToAction("Login", "Account", new { area = "Admin" });
        }


        
    }
}
