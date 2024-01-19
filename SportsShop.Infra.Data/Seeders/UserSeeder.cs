using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsShop.Domain.Models.Users;
using SportsShop.Domain.Security;

namespace SportsShop.Infra.Data.Seeders
{
    public class UserSeeder : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {

            builder.HasData(new User
            {
                UserName = "superadmin",
                FullName = "سوپر ادمین",
                Id = 1,
                RoleId = 1,
                Password =PasswordHelper.EncodePasswordMd5("1qaz@WSX3edc") ,
                CreateDate = new DateTime(2023, 12, 20, 19, 23, 0, 0, DateTimeKind.Local).AddTicks(2972),

            });
        }
    }
}