using System.Collections.Generic;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.User;

namespace SportsShop.Domain.Interfaces
{
 public   interface IPermissionRepository
    {
       
        List<Role> GetRoles();
       
        List<Permission> GetAllPermission();
       
        int AddRole(Role role);

        void AddRolePermission(List<RolePermission> rolePermissions);
       
        List<int> PermissionsRole(int roleId);
     
        Role GetRoleByRoleId(int roleId);
      
        void UpdateRole(Role role);
       
        void DeletePermissionsRole(int roleId);
      
        void AddRolesToUser(List<UserRole> userRoles);
       
        void DeleteUserRoles(int userid);
        
        bool CheckDelete(int roleId);
       
        List<int> GetUserRolesByUserId(int userId);
       
        List<int> GetRolePermissionByPermissionId(int permissionId);
    }
}
