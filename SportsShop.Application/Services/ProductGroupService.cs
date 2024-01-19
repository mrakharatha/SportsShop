using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Product;

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
    }
}