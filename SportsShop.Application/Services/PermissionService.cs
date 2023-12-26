using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Permissions;

namespace SportsShop.Application.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        
        }


        public List<SelectListItem> GetRoleSelectList()
        {
            List<SelectListItem> result = new List<SelectListItem>()
            {
                new SelectListItem()
                {
                    Value = null,
                    Text = "لطفا انتخاب کنید",
                }
            };

            result.AddRange(_permissionRepository.GetRoleSelectList());

            return result;
        }

        public List<Role> GetRoles()
        {
            return _permissionRepository.GetRoles();
        }

        public List<Permission> GetAllPermission()
        {
            return _permissionRepository.GetAllPermission();
        }

        public int AddRole(Role role)
        {
            return _permissionRepository.AddRole(role);
        }

        public void AddPermissionsToRole(int roleId, List<int> permission)
        {
            List<RolePermission> rolePermissions = new List<RolePermission>();
            foreach (var p in permission)
            {
                rolePermissions.Add(new RolePermission()
                {
                    PermissionId = p,
                    RoleId = roleId
                });
            }
            _permissionRepository.AddRolePermission(rolePermissions);
        }

        public List<int> PermissionsRole(int roleId)
        {
            return _permissionRepository.PermissionsRole(roleId);
        }

        public Role GetRoleByRoleId(int roleId)
        {
            return _permissionRepository.GetRoleByRoleId(roleId);
        }

        public void UpdateRole(Role role)
        {
            role.UpdateDate = DateTime.Now;
            _permissionRepository.UpdateRole(role);
        }

        public void UpdatePermissionsRole(int roleId, List<int> permissions)
        {
            List<RolePermission> rolePermissions = new List<RolePermission>();
            foreach (var p in permissions)
            {
                rolePermissions.Add(new RolePermission()
                {
                    PermissionId = p,
                    RoleId = roleId
                });
            }


            _permissionRepository.DeletePermissionsRole(roleId);
            _permissionRepository.AddRolePermission(rolePermissions);
        }



        public bool CheckPermission(int permissionId, int userId)
        {
            return _permissionRepository.CheckPermission(permissionId, userId);
        }



        public bool CheckDelete(int roleId)
        {
            return _permissionRepository.CheckDelete(roleId);
        }

        public RequestResult DeleteRole(int roleId)
        {

            var role = GetRoleByRoleId(roleId);

            if (role.RoleId == 1 |  CheckDelete(roleId)||role.RoleId==roleId)
                return new RequestResult(false, RequestResultStatusCode.InternalServerError, "نقش در سیستم استفاده شده است!");
         
            role.DeleteDate = DateTime.Now;
            UpdateRole(role);

            return new RequestResult(true, RequestResultStatusCode.Success, "نقش با موفقیت حذف شد.");
        }


        public List<int> GetRolePermissionByPermissionId(int permissionId)
        {
            return _permissionRepository.GetRolePermissionByPermissionId(permissionId);
        }
    }
}
