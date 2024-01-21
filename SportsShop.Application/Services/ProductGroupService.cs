using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Products;
using SportsShop.Domain.Models.Users;

namespace SportsShop.Application.Services
{
    public class ProductGroupService: IProductGroupService
    {
        private readonly IProductGroupRepository _productGroupRepository;

        public ProductGroupService(IProductGroupRepository productGroupRepository)
        {
            _productGroupRepository = productGroupRepository;
        }

        public List<ProductGroup> GetAll()
        {
            return _productGroupRepository.GetAll();
        }

        public List<SelectListItem> GetAllProductGroups(bool checkIsNullParent)
        {
            List<SelectListItem> result = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = null,
                    Text = "لطفا انتخاب کنید",
                }
            };

            result.AddRange(_productGroupRepository.GetAllProductGroups( checkIsNullParent));

            return result;
        }

        public void AddProductGroup(ProductGroup productGroup)
        {
            _productGroupRepository.AddProductGroup(productGroup);
        }

        public void UpdateProductGroup(ProductGroup productGroup)
        {
            productGroup.UpdateDate = DateTime.Now;
            _productGroupRepository.UpdateProductGroup(productGroup);
        }

        public ProductGroup GetProductGroupById(int productGroupId)
        {
            return _productGroupRepository.GetProductGroupById(productGroupId);
        }

        public RequestResult DeleteProductGroup(int productGroupId)
        {
            var productGroup = GetProductGroupById(productGroupId);
            if (productGroup == null) return new RequestResult(false, RequestResultStatusCode.InternalServerError);

            if (IsExist(productGroupId))
                return new RequestResult(false, RequestResultStatusCode.InternalServerError, "گروه کالا در سیستم استفاده شده است!");

            productGroup.DeleteDate = DateTime.Now;
            UpdateProductGroup(productGroup);
            return new RequestResult(true, RequestResultStatusCode.Success, "گروه کالا با موفقیت حذف شد.");
        }

        public bool IsExist(int productGroupId)
        {
            return _productGroupRepository.IsExist(productGroupId);
        }

    }
}