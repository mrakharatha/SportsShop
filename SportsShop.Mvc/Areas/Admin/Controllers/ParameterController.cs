using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Application.Services;
using SportsShop.Domain.Models.Products;
using SportsShop.Domain.Security;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    public class ParameterController : BaseController
    {
        private readonly IParameterService _parameterService;
        private readonly IPermissionService _permissionService;
        public ParameterController(IParameterService parameterService, IPermissionService permissionService)
        {
            _parameterService = parameterService;
            _permissionService = permissionService;
        }


        [PermissionChecker(16)]
        public IActionResult Index()
        {
            return View(_parameterService.GetAll());
        }


        [PermissionChecker(17)]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Parameter parameter)
        {
            if (!ModelState.IsValid)
                return View(parameter);



            _parameterService.AddParameter(parameter);
            return RedirectToAction("Index");
        }

        [PermissionChecker(18)]
        public IActionResult Update(int id)
        {
            return View(_parameterService.GetParameterById(id));
        }


        [HttpPost]
        public IActionResult Update(Parameter parameter)
        {
            if (!ModelState.IsValid)
                return View(parameter);


            _parameterService.UpdateParameter(parameter);
            return RedirectToAction("Index");
        }



        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(19, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _parameterService.DeleteParameter(id);
        }
    }
}
