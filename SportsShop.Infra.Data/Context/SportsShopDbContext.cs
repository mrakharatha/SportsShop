using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.Products;
using SportsShop.Domain.Models.Stores;
using SportsShop.Domain.Models.Users;
using SportsShop.Infra.Data.Seeders;
using Parameter = SportsShop.Domain.Models.Products.Parameter;

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
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<ParameterValue> ParameterValues { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;


            modelBuilder.Entity<Role>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<User>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<ProductGroup>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<Parameter>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<ParameterValue>().HasQueryFilter(c => c.DeleteDate == null);


            var assembly = typeof(PermissionSeeder).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }

       
    }
}
