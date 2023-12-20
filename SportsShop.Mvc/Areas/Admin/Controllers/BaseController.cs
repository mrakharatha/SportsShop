using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{

    [Area("Admin")]
    [Authorize(Roles = "Admin", AuthenticationSchemes = "Admin_Schema")]
    public class BaseController : Controller
    {
        
    }
}
