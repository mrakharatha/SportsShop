using System;
using System.Collections.Generic;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Banner;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Services
{
    public class SliderService: ISliderService
    {
      private  readonly ISliderRepository _sliderRepository;
     private   readonly IGlobalService _globalService;
        public SliderService(ISliderRepository sliderRepository, IGlobalService globalService)
        {
            _sliderRepository = sliderRepository;
            _globalService = globalService;
        }

        public List<Slider> GetAll()
        {
            return _sliderRepository.GetAll();
        }

        public void AddSlider(Slider slider)
        {
            slider.SliderImage = _globalService.Upload(slider.Image, "SliderImage");
            _sliderRepository.AddSlider(slider);
        }

        public Slider GetSliderById(int sliderId)
        {
            return _sliderRepository.GetSliderById(sliderId);
        }

        public void UpdateSlider(Slider slider)
        {
            slider.SliderImage = _globalService.Upload(slider.Image, "SliderImage",slider.SliderImage);
            slider.UpdateDate=DateTime.Now;
            _sliderRepository.UpdateSlider(slider);
        }

        public RequestResult DeleteSlider(int sliderId)
        {
            var slider = GetSliderById(sliderId);
            if (slider == null) return new RequestResult(false, RequestResultStatusCode.InternalServerError);

           
            slider.DeleteDate = DateTime.Now;
            UpdateSlider(slider);
            return new RequestResult(true, RequestResultStatusCode.Success, " اسلایدر با موفقیت حذف شد.");
        }
    }
}