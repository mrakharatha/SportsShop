using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Application.Services;
using SportsShop.Domain.Dtos.Products;
using SportsShop.Domain.Models.Banner;
using SportsShop.Domain.Models.Products;
using SportsShop.Domain.Security;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{

    public class SliderController : BaseController
    {
        private readonly ISliderService _sliderService;
        private readonly IPermissionService _permissionService;
        public SliderController(ISliderService sliderService, IPermissionService permissionService)
        {
            _sliderService = sliderService;
            _permissionService = permissionService;
        }


        [PermissionChecker(36)]
        public IActionResult Index()
        {
            return View(_sliderService.GetAll());
        }



        [PermissionChecker(37)]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            if (!ModelState.IsValid)
                return View(slider);

            if (slider.Image == null)
            {
                ModelState.AddModelError("All", "لطفا تصویر اسلایدر را انتخاب کنید");
                return View(slider);
            }

            if (slider.ActiveButton && string.IsNullOrWhiteSpace(slider.NameButton))
            {
                ModelState.AddModelError(nameof(slider.NameButton), "لطفا عنوان نمایشی کلید را وارد کنید");
                return View(slider);
            }
            _sliderService.AddSlider(slider);

            return RedirectToAction("Index");
        }


        [PermissionChecker(38)]
        public IActionResult Update(int id)
        {
            return View(_sliderService.GetSliderById(id));
        }

        [HttpPost]
        public IActionResult Update(Slider slider)
        {
            if (!ModelState.IsValid)
                return View(slider);

            if (slider.ActiveButton && string.IsNullOrWhiteSpace(slider.NameButton))
            {
                ModelState.AddModelError(nameof(slider.NameButton), "لطفا عنوان نمایشی کلید را وارد کنید");
                return View(slider);
            }
            _sliderService.UpdateSlider(slider);

            return RedirectToAction("Index");
        }


        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(39, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);

            return _sliderService.DeleteSlider(id);
        }

    }
}
