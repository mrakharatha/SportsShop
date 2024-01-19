using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsShop.Domain.Models.Permissions;

namespace SportsShop.Infra.Data.Seeders
{
    public class RoleSeeder : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(new Role
            {
                Id = 1,
                Title = "مدیر",
                CreateDate = new DateTime(2023, 12, 20, 19, 17, 32, 968, DateTimeKind.Local).AddTicks(1379)
            });
        }
    }
}