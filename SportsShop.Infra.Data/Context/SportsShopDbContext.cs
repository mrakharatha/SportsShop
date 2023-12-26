using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.Stores;
using SportsShop.Domain.Models.Users;
using SportsShop.Infra.Data.Seeders;

namespace SportsShop.Infra.Data.Context
{
    public class SportsShopDbContext : DbContext
    {
        public SportsShopDbContext(DbContextOptions<SportsShopDbContext> options) : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Office> Offices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;


            modelBuilder.Entity<Role>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<User>().HasQueryFilter(c => c.DeleteDate == null);


            var assembly = typeof(PermissionSeeder).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }

       
    }
}
