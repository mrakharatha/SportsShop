using System.Collections;
using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Application.Services;
using SportsShop.Domain.Dtos.Products;
using SportsShop.Domain.Security;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;
        private readonly IPermissionService _permissionService;
        public ProductController(IProductService productService, IPermissionService permissionService)
        {
            _productService = productService;
            _permissionService = permissionService;
        }


        [PermissionChecker(24)]
        public IActionResult Index()
        {
            return View(_productService.GetAll());
        }

        [PermissionChecker(25)]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductDto product)
        {
            if (!ModelState.IsValid)
                return View(product);

            if (product.ProductImage == null)
            {
                ModelState.AddModelError("All", "لطفا تصویر محصول را انتخاب کنید");
                return View(product);
            }


            _productService.AddProduct(product);

            return RedirectToAction("Index");
        }

        [PermissionChecker(26)]
        public IActionResult Update(int id)
        {
            return View(_productService.GetProductDtoById(id));
        }

        [HttpPost]
        public IActionResult Update(ProductDto product)
        {
            if (!ModelState.IsValid)
                return View(product);


            _productService.UpdateProduct(product);
            return RedirectToAction("Index");
        }


        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(27, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);

            return _productService.DeleteProduct(id);
        }
    }
}
