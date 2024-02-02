using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace SportsShop.Application.Interfaces
{
    public interface IGlobalService
    {
        List<SelectListItem> GetStatus();
        string Upload(IFormFile file, string path, string oldPath = null);

    }
}