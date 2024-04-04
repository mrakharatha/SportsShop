using SportsShop.Domain.Models.Banner;
using System.Collections.Generic;

namespace SportsShop.Domain.Interfaces
{
    public interface ISliderRepository
    {
        List<Slider> GetAll();
        void AddSlider(Slider slider);

        Slider GetSliderById(int sliderId);
        void UpdateSlider(Slider slider);
    }
}