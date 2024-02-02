using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Domain.Models.Products;
using System.Collections.Generic;

namespace SportsShop.Application.Interfaces
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        List<SelectListItem> GetAllBrands();
        void AddBrand(Brand brand);
        void UpdateBrand(Brand brand);
        Brand GetBrandById(int brandId);
        RequestResult DeleteBrand(int brandId);
        bool IsExist(int brandId);
    }
}