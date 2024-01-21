using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Application.Interfaces
{
    public interface IProductGroupService
    {
        List<ProductGroup> GetAll();

        List<SelectListItem> GetAllProductGroups(bool checkIsNullParent);

        void AddProductGroup(ProductGroup productGroup);
        void UpdateProductGroup(ProductGroup productGroup);
        ProductGroup GetProductGroupById(int productGroupId);
        RequestResult DeleteProductGroup(int productGroupId);
        bool IsExist(int productGroupId);
    }
}