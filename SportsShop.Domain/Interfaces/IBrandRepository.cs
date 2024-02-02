using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Domain.Models.Products;
using System.Collections.Generic;

namespace SportsShop.Domain.Interfaces
{
    public interface IBrandRepository
    {
        List<Brand> GetAll();
        List<SelectListItem> GetAllBrands();
        void AddBrand(Brand brand);
        void UpdateBrand(Brand brand);
        Brand GetBrandById(int brandId);
        bool IsExist(int brandId);
    }
}