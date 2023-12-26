using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsShop.Domain.Models.Permissions;

namespace SportsShop.Domain.Interfaces
{
 public   interface IPermissionRepository
    {
        List<SelectListItem> GetRoleSelectList();

        List<Role> GetRoles();
       
        List<Permission> GetAllPermission();
       
        int AddRole(Role role);

        void AddRolePermission(List<RolePermission> rolePermissions);
       
        List<int> PermissionsRole(int roleId);
     
        Role GetRoleByRoleId(int roleId);
      
        void UpdateRole(Role role);
       
        void DeletePermissionsRole(int roleId);
        
        bool CheckDelete(int roleId);
        List<int> GetRolePermissionByPermissionId(int permissionId);
        bool CheckPermission(int permissionId, int userId);
    }
}
