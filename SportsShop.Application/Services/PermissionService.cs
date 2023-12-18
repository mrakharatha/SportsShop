using System;
using System.Collections.Generic;
using System.Linq;
using SportsShop.Application.Interfaces;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.User;

namespace SportsShop.Application.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IPermissionRepository _permissionRepository;
        

        public PermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        
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

        public void AddRolesToUser(List<int> rolesId, int userId)
        {
            List<UserRole> userRoles = new List<UserRole>();
            foreach (var roleId in rolesId)
            {
                userRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId
                });
            }
            _permissionRepository.AddRolesToUser(userRoles);
        }

        public bool CheckPermission(int permissionId, int userId)
        {
            if (userId == 1)
                return true;

            var userRoles = GetUserRolesByUserId(userId);

            if (!userRoles.Any())
                return false;

            var rolePermission = GetRolePermissionByPermissionId(permissionId);

            return rolePermission.Any(p => userRoles.Contains(p));
        }

        public void DeleteUserRoles(int userid)
        {
            _permissionRepository.DeleteUserRoles(userid);
        }

        public bool CheckDelete(int roleId)
        {
            return _permissionRepository.CheckDelete(roleId);
        }

        public void DeleteRole(int roleId)
        {
            Role role = GetRoleByRoleId(roleId);
            role.DeleteDate = DateTime.Now;
            UpdateRole(role);
        }

        public void UpdateRolesToUser(List<int> rolesId, int userId)
        {
            DeleteUserRoles(userId);
            AddRolesToUser(rolesId,userId);
        }

        public List<int> GetUserRolesByUserId(int userId)
        {
            return _permissionRepository.GetUserRolesByUserId(userId);
        }

        public List<int> GetRolePermissionByPermissionId(int permissionId)
        {
            return _permissionRepository.GetRolePermissionByPermissionId(permissionId);
        }
    }
}
