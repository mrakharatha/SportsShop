using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Banner;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
    public class SliderRepository : ISliderRepository
    {
        private readonly SportsShopDbContext _context;

        public SliderRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<Slider> GetAll()
        {
            return _context.Sliders
                .Include(x => x.User)
                .OrderByDescending(x => x.Id)
                .ToList();
        }

        public void AddSlider(Slider slider)
        {
            _context.Add(slider);
            _context.SaveChanges();
        }

        public Slider GetSliderById(int sliderId)
        {
            return _context.Sliders.Find(sliderId);
        }

        public void UpdateSlider(Slider slider)
        {
            _context.Update(slider);
            _context.SaveChanges();
        }
    }
}