using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.EntityFrameworkCore;
using SportsShop.Domain.Models.Banner;
using SportsShop.Domain.Models.Permissions;
using SportsShop.Domain.Models.Products;
using SportsShop.Domain.Models.Stores;
using SportsShop.Domain.Models.Users;
using SportsShop.Domain.Utilities;
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
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<ProductGallery> ProductGalleries { get; set; }
        public DbSet<Slider> Sliders { get; set; }

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
            modelBuilder.Entity<Product>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<Brand>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<ProductGallery>().HasQueryFilter(c => c.DeleteDate == null);
            modelBuilder.Entity<Slider>().HasQueryFilter(c => c.DeleteDate == null);


            var assembly = typeof(PermissionSeeder).Assembly;
            modelBuilder.ApplyConfigurationsFromAssembly(assembly);
            base.OnModelCreating(modelBuilder);
        }
        public override int SaveChanges()
        {
            _cleanString();
            return base.SaveChanges();
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {

            _cleanString();
            return base.SaveChanges(acceptAllChangesOnSuccess);

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            _cleanString();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void _cleanString()
        {
            var changedEntities = ChangeTracker.Entries()
                .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);
            foreach (var item in changedEntities)
            {
                if (item.Entity == null)
                    continue;

                var properties = item.Entity.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .Where(p => p.CanRead && p.CanWrite && p.PropertyType == typeof(string));

                foreach (var property in properties)
                {
                    var val = (string)property.GetValue(item.Entity, null);
                    if (val.HasValue())
                    {
                        var newVal = val.Fa2En().FixPersianChars().Trim();
                        if (newVal == val)
                            continue;
                        property.SetValue(item.Entity, newVal, null);
                    }
                }
            }
        }

    }
}
