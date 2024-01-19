using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Product;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    public class ProductGroupController : BaseController
    {
        private readonly IProductGroupService _productGroupService;

        public ProductGroupController(IProductGroupService productGroupService)
        {
            _productGroupService = productGroupService;
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
    }
}
