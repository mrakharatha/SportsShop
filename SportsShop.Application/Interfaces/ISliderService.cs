using System.Collections.Generic;
using SportsShop.Application.Helpers;
using SportsShop.Domain.Models.Banner;

namespace SportsShop.Application.Interfaces
{
    public interface ISliderService
    {
        List<Slider> GetAll();
        void AddSlider(Slider slider);
        Slider GetSliderById(int sliderId);
        void UpdateSlider(Slider slider);
        RequestResult DeleteSlider(int sliderId);
    }
}