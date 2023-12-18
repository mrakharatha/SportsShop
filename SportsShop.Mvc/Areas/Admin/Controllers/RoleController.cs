﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsShop.Application.Interfaces;
using SportsShop.Application.Security;
using SportsShop.Domain.Models.Permissions;

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
            ViewData["Permissions"] = _permissionService.GetAllPermission();
            return View();
        }



        [HttpPost]
        public IActionResult RoleCreate(Role role, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Permissions"] = _permissionService.GetAllPermission();
                return View();
            }

            int roleId = _permissionService.AddRole(role);

            _permissionService.AddPermissionsToRole(roleId, selectedPermission);

            return RedirectToAction("Index");
        }


        public IActionResult RoleEdit(int id)
        {
            ViewData["Permissions"] = _permissionService.GetAllPermission();
            ViewData["SelectedPermissions"] = _permissionService.PermissionsRole(id);
            return View(_permissionService.GetRoleByRoleId(id));
        }

        [HttpPost]
        public IActionResult RoleEdit(Role role, List<int> selectedPermission)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Permissions"] = _permissionService.GetAllPermission();
                ViewData["SelectedPermissions"] = _permissionService.PermissionsRole(role.RoleId);
                return View(role);
            }

            _permissionService.UpdateRole(role);
            _permissionService.UpdatePermissionsRole(role.RoleId, selectedPermission);

            return RedirectToAction("Index");
        }

        public int Delete(int id)
        {
            if (!_permissionService.CheckPermission(6, User.GetUserId()))
                return 1;
            if (_permissionService.CheckDelete(id))
                return 2;
            _permissionService.DeleteRole(id);
            return 3;
        }
    }
}