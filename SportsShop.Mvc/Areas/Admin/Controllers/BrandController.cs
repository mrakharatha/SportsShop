using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Domain.Models.Products;
using SportsShop.Domain.Security;
using System.Drawing.Drawing2D;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{
    public class BrandController : BaseController
    {
        private readonly IPermissionService _permissionService;
        private readonly IBrandService _brandService;
        public BrandController(IPermissionService permissionService, IBrandService brandService)
        {
            _permissionService = permissionService;
            _brandService = brandService;
        }


        [PermissionChecker(28)]
        public IActionResult Index()
        {
            return View(_brandService.GetAll());
        }


        [PermissionChecker(29)]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Brand brand)
        {
            if (!ModelState.IsValid)
                return View(brand);

            _brandService.AddBrand(brand);

            return RedirectToAction("Index");
        }

        [PermissionChecker(30)]
        public IActionResult Update(int id)
        {
            return View(_brandService.GetBrandById(id));
        }


        [HttpPost]
        public IActionResult Update(Brand brand)
        {
            if (!ModelState.IsValid)
                return View(brand);


            _brandService.UpdateBrand(brand);
            return RedirectToAction("Index");
        }



        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(31, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _brandService.DeleteBrand(id);
        }
    }
}
