﻿using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportsShop.Domain.Models.Permissions;

namespace SportsShop.Infra.Data.Seeders
{
    public class PermissionSeeder : IEntityTypeConfiguration<Permission>
    {
        //سطح دسترسی
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasData(new List<Permission>()
            {
                new Permission(){PermissionId = 1,PermissionTitle = "داشبورد",ParentId = null},
                new Permission(){PermissionId = 2,PermissionTitle = "اطلاعات پایه",ParentId = null},
                new Permission(){PermissionId = 3,PermissionTitle = "سطح دسترسی",ParentId = 2},
                new Permission(){PermissionId = 4,PermissionTitle = "افزودن سطح دسترسی",ParentId = 3},
                new Permission(){PermissionId = 5,PermissionTitle = "ویرایش سطح دسترسی",ParentId = 3},
                new Permission(){PermissionId = 6,PermissionTitle = "حذف سطح دسترسی",ParentId = 3},
                new Permission(){PermissionId = 11,PermissionTitle = "کاربران",ParentId = 2},
                new Permission(){PermissionId = 12,PermissionTitle = "افزودن کاربران",ParentId = 11},
                new Permission(){PermissionId = 13,PermissionTitle = "ویرایش کاربران",ParentId = 11},
                new Permission(){PermissionId = 14,PermissionTitle = "حذف کاربران",ParentId = 11},
               
            });
        }
    }
}