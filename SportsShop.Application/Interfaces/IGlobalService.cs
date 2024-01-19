using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SportsShop.Application.Interfaces
{
    public interface IGlobalService
    {
        List<SelectListItem> GetStatus();
    }
}