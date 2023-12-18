using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{

    [Area("Admin")]
  //  [Authorize(Roles = "admin", AuthenticationSchemes = "Admin_Schema")]
    public class BaseController : Controller
    {
        
    }
}
