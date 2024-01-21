using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Application.Services;
using SportsShop.Domain.Security;
using ParameterValue = SportsShop.Domain.Models.Products.ParameterValue;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    public class ParameterValueController : BaseController
    {
        private readonly IParameterValueService _parameterValueService;
       private readonly IPermissionService _permissionService;
        public ParameterValueController(IParameterValueService parameterValueService, IPermissionService permissionService)
        {
            _parameterValueService = parameterValueService;
            _permissionService = permissionService;
        }

        [PermissionChecker(20)]
        public IActionResult Index(int id)
        {
            ViewBag.ParameterId=id;
            return View(_parameterValueService.GetAll(id));
        }

        [PermissionChecker(21)]
        public IActionResult Create(int parameterId)
        {
            return View(new ParameterValue()
            {
                ParameterId = parameterId,
            });
        }

        [HttpPost]
        public IActionResult Create(ParameterValue parameterValue)
        {
            if (!ModelState.IsValid)
                return View(parameterValue);

            _parameterValueService.AddParameterValue(parameterValue);

            return RedirectToAction("Index",new {id=parameterValue.ParameterId});
        }

        [PermissionChecker(22)]
        public IActionResult Update(int id)
        {
            return View(_parameterValueService.GetParameterValueById(id));
        }

        [HttpPost]
        public IActionResult Update(ParameterValue parameterValue)
        {
            if (!ModelState.IsValid)
                return View(parameterValue);

            _parameterValueService.UpdateParameterValue(parameterValue);

            return RedirectToAction("Index", new { id = parameterValue.ParameterId });
        }

        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(23, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _parameterValueService.DeleteParameterValue(id);
        }
    }
}
