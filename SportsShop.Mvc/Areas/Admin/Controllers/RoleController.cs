using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Security;

namespace SportsShop.Mvc.Areas.Admin.Controllers
{

    public class RoleController : BaseController
    {
   
        private readonly IPermissionService _permissionService;

        public RoleController(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        [PermissionChecker(3)]
        public IActionResult Index()
        {
            return View(_permissionService.GetRoles());
        }
        [PermissionChecker(4)]

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(Role role, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
                return View();
            

            int roleId = _permissionService.AddRole(role);

            _permissionService.AddPermissionsToRole(roleId, selectedPermission);

            return RedirectToAction("Index");
        }

        [PermissionChecker(5)]

        public IActionResult Update(int id)
        {
            return View(_permissionService.GetRoleByRoleId(id));
        }

        [HttpPost]
        public IActionResult Update(Role role, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
                return View(role);
            

            _permissionService.UpdateRole(role);
            _permissionService.UpdatePermissionsRole(role.Id, selectedPermission);

            return RedirectToAction("Index");
        }

        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(6, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _permissionService.DeleteRole(id);
        }


     
    }
}
