using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Interfaces;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.User;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Repository
{
    public class PermissionRepository : IPermissionRepository
    {
        private readonly SportsShopDbContext _context;

        public PermissionRepository(SportsShopDbContext context)
        {
            _context = context;
        }

        public List<SelectListItem> GetRoleSelectList()
        {
            return _context.Roles.Where(x => x.RoleId != 1).Select(r => new SelectListItem()
            {
                Text = r.RoleTitle,
                Value = r.RoleId.ToString()
            }).ToList();
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.Where(x => x.RoleId != 1).OrderByDescending(r => r.CreateDate).ToList();
        }

        public List<Permission> GetAllPermission()
        {
            return _context.Permissions.ToList();
        }

        public int AddRole(Role role)
        {
            _context.Add(role);
            _context.SaveChanges();
            return role.RoleId;
        }

        public void AddRolePermission(List<RolePermission> rolePermissions)
        {
            _context.AddRange(rolePermissions);
            _context.SaveChanges();
        }

        public List<int> PermissionsRole(int roleId)
        {
            return _context.RolePermissions.Where(r => r.RoleId == roleId)
                .Select(r => r.PermissionId)
                .ToList();
        }

        public Role GetRoleByRoleId(int roleId)
        {
            return _context.Roles.Find(roleId);
        }

        public void UpdateRole(Role role)
        {
            var oldRole = GetRoleByRoleId(role.RoleId);
            _context.Entry(oldRole).CurrentValues.SetValues(role);
            _context.SaveChanges();
        }
        public void DeletePermissionsRole(int roleId)
        {
            _context.RolePermissions.Where(p => p.RoleId == roleId)
                .ToList().ForEach(p => _context.RolePermissions.Remove(p));

            _context.SaveChanges();
        }

      

        public bool CheckDelete(int roleId)
        {
            return _context.Users.Any(c => c.RoleId == roleId);
        }

        

        public List<int> GetRolePermissionByPermissionId(int permissionId)
        {
            return _context.RolePermissions
                .Where(p => p.PermissionId == permissionId)
                .Select(p => p.RoleId)
                .ToList();
        }

        public bool CheckPermission(int permissionId, int userId)
        {

            if (userId.Equals(1))
                return true;

            var user = _context.Users.Find(userId);
            return _context.RolePermissions.Any(r => r.RoleId == user.RoleId && r.PermissionId == permissionId);
        }
    }
}
