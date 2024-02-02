using System.Collections;
using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Domain.Dtos.Products;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
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
    }
}
