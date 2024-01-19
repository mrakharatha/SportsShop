using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Domain.Models.Product;

namespace SportsShop.Application.Interfaces
{
    public interface IProductGroupService
    {
        List<ProductGroup> GetAll();

        List<SelectListItem> GetAllProductGroups(bool checkIsNullParent);

    }
}