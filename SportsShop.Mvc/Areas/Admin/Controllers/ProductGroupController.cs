using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Application.Services;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Product;
using SportsShop.Domain.Security;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    public class ProductGroupController : BaseController
    {
        private readonly IProductGroupService _productGroupService;
        private readonly IPermissionService _permissionService;
        public ProductGroupController(IProductGroupService productGroupService, IPermissionService permissionService)
        {
            _productGroupService = productGroupService;
            _permissionService = permissionService;
        }

        [PermissionChecker(12)]
        public IActionResult Index()
        {
            return View(_productGroupService.GetAll());
        }


        [PermissionChecker(13)]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductGroup productGroup)
        {
            if (!ModelState.IsValid)
                return View(productGroup);



            _productGroupService.AddProductGroup(productGroup);

            return RedirectToAction("Index");
        }

        [PermissionChecker(14)]
        public IActionResult Update(int id)
        {
            return View(_productGroupService.GetProductGroupById(id));
        }


        [HttpPost]
        public IActionResult Update(ProductGroup productGroup)
        {
            if (!ModelState.IsValid)
                return View(productGroup);


            _productGroupService.UpdateProductGroup(productGroup);
            return RedirectToAction("Index");
        }



        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(15, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _productGroupService.DeleteProductGroup(id);
        }

    }
}
