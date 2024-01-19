using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Domain.Models.Product;
using System.Collections.Generic;

namespace SportsShop.Domain.Interfaces
{
    public interface IProductGroupRepository
    {
        List<ProductGroup> GetAll();
        List<SelectListItem> GetAllProductGroups(bool checkIsNullParent);

    }
}