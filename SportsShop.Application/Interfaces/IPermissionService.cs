using SportsShop.Domain.Models.Permissions;
using System.Collections.Generic;
using System.Data;
using System.Security;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Application.Helpers;

namespace SportsShop.Application.Interfaces
{
    public interface IPermissionService
    {
        List<SelectListItem> GetRoleSelectList();

        List<Role> GetRoles();
       
        List<Permission> GetAllPermission();
       
        int AddRole(Role role);
       
        void AddPermissionsToRole(int roleId, List<int> permission);
     
        List<int> PermissionsRole(int roleId);
       
        Role GetRoleByRoleId(int roleId);
       
        void UpdateRole(Role role);
       
        void UpdatePermissionsRole(int roleId, List<int> permissions);
        
        bool CheckPermission(int permissionId, int userId);
     
     
        bool CheckDelete(int roleId);

        RequestResult DeleteRole(int roleId);
    }
}