using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using SportsShop.Domain.Models.Products;

namespace SportsShop.Domain.Interfaces
{
    public interface IProductGroupRepository
    {
        List<ProductGroup> GetAll();
        List<SelectListItem> GetAllProductGroups(bool checkIsNullParent);
        void AddProductGroup(ProductGroup productGroup);
        void UpdateProductGroup(ProductGroup productGroup);
        ProductGroup GetProductGroupById(int productGroupId);
        bool IsExist(int productGroupId);

    }
}