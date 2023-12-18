using SportsShop.Domain.Models.Permissions;
using System.Collections.Generic;
using System.Data;
using System.Security;

namespace SportsShop.Application.Interfaces
{
    public interface IPermissionService
    {
        
        List<Role> GetRoles();
       
        List<Permission> GetAllPermission();
       
        int AddRole(Role role);
       
        void AddPermissionsToRole(int roleId, List<int> permission);
     
        List<int> PermissionsRole(int roleId);
       
        Role GetRoleByRoleId(int roleId);
       
        void UpdateRole(Role role);
       
        void UpdatePermissionsRole(int roleId, List<int> permissions);
       
        void AddRolesToUser(List<int> rolesId, int userId);
        
        bool CheckPermission(int permissionId, int userId);
     
        void DeleteUserRoles(int userId);
     
        bool CheckDelete(int roleId);
       
        void DeleteRole(int roleId);
   
        void UpdateRolesToUser(List<int> rolesId, int userId);
      
        List<int> GetUserRolesByUserId(int userId);
       
        List<int> GetRolePermissionByPermissionId(int permissionId);
    }
}