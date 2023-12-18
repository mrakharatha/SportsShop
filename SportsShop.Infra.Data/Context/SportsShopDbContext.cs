using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SportsShop.Infra.Data.Context
{
    public class SportsShopDbContext : DbContext
    {
        public SportsShopDbContext(DbContextOptions<SportsShopDbContext> options) : base(options)
        {
        }

    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;

        }

       
    }
}
