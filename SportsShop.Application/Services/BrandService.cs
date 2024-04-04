using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace SportsShop.Application.Services
{
    public class BrandService: IBrandService
    {
        private readonly IBrandRepository _brandRepository;
       private readonly IGlobalService _globalService;
        public BrandService(IBrandRepository brandRepository, IGlobalService globalService)
        {
            _brandRepository = brandRepository;
            _globalService = globalService;
        }

        public List<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public List<SelectListItem> GetAllBrands()
        {
            List<SelectListItem> result = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = null,
                    Text = "لطفا انتخاب کنید",
                }
            };

            result.AddRange(_brandRepository.GetAllBrands());

            return result;
        }

        public void AddBrand(Brand brand)
        {
            brand.BrandImage = _globalService.Upload(brand.Image, "BrandImage");

            _brandRepository.AddBrand(brand);
        }

        public void UpdateBrand(Brand brand)
        {
            brand.BrandImage = _globalService.Upload(brand.Image, "BrandImage",brand.BrandImage);

            brand.UpdateDate = DateTime.Now;
            _brandRepository.UpdateBrand(brand);
        }

        public Brand GetBrandById(int brandId)
        {
            return _brandRepository.GetBrandById(brandId);
        }

        public RequestResult DeleteBrand(int brandId)
        {
            var brand = GetBrandById(brandId);
            if (brand == null) return new RequestResult(false, RequestResultStatusCode.InternalServerError);

            if (IsExist(brandId))
                return new RequestResult(false, RequestResultStatusCode.InternalServerError, "برند کالا در سیستم استفاده شده است!");

            brand.DeleteDate = DateTime.Now;
            UpdateBrand(brand);
            return new RequestResult(true, RequestResultStatusCode.Success, "برند کالا با موفقیت حذف شد.");
        }

        public bool IsExist(int brandId)
        {
            return _brandRepository.IsExist(brandId);
        }
    }
}