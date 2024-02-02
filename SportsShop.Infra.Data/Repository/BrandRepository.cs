using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;
using SportsShop.Infra.Data.Context;
using System.Collections.Generic;
using System.Linq;

namespace SportsShop.Infra.Data.Repository
{
    public class BrandRepository: IBrandRepository
    {
    private    readonly SportsShopDbContext _context;

        public BrandRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<Brand> GetAll()
        {
            return _context.Brands
                .Include(x => x.User)
                .OrderByDescending(x => x.Id)
                .ToList();
        }

        public List<SelectListItem> GetAllBrands()
        {
            return _context.Brands
                .OrderByDescending(x => x.Id)
                .Select(r => new SelectListItem()
                {
                    Text = r.Name,
                    Value = r.Id.ToString()
                }).ToList();
        }

        public void AddBrand(Brand brand)
        {
            _context.Add(brand);
            _context.SaveChanges();
        }

        public void UpdateBrand(Brand brand)
        {
            _context.Update(brand);
            _context.SaveChanges();
        }

        public Brand GetBrandById(int brandId)
        {
            return _context.Brands.Find(brandId);
        }

        public bool IsExist(int brandId)
        {
            return _context.Products.Any(x => x.BrandId == brandId);
        }

    }
}