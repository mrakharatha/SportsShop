using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Interfaces;

namespace SportsShop.Application.Services
{
    public class GlobalService : IGlobalService
    {
        public List<SelectListItem> GetStatus()
        {
            return new List<SelectListItem>()
            {
                new ()
                {
                    Value = true.ToString(),
                    Text = "فعال",
                },
                new ()
                {
                    Value = false.ToString(),
                    Text = "غیر فعال",
                },
            };

        }
    }
}