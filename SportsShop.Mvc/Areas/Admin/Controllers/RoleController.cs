﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
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
        public IActionResult Index()
        {
            return View(_permissionService.GetRoles());
        }

        public IActionResult RoleCreate()
        {
            return View();
        }



        [HttpPost]
        public IActionResult RoleCreate(Role role, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int roleId = _permissionService.AddRole(role);

            _permissionService.AddPermissionsToRole(roleId, selectedPermission);

            return RedirectToAction("Index");
        }


        public IActionResult RoleEdit(int id)
        {
            return View(_permissionService.GetRoleByRoleId(id));
        }

        [HttpPost]
        public IActionResult RoleEdit(Role role, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
            {
                return View(role);
            }

            _permissionService.UpdateRole(role);
            _permissionService.UpdatePermissionsRole(role.RoleId, selectedPermission);

            return RedirectToAction("Index");
        }

        public RequestResult Delete(int id)
        {
            if (!_permissionService.CheckPermission(14, User.GetUserId()))
                return new RequestResult(false, RequestResultStatusCode.Forbidden);


            return _permissionService.DeleteRole(id);
        }


     
    }
}
