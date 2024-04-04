using System.Collections.Generic;
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
                new (){PermissionId = 1,PermissionTitle = "داشبورد",ParentId = null},

                new (){PermissionId = 2,PermissionTitle = "اطلاعات پایه",ParentId = null},

                new (){PermissionId = 3,PermissionTitle = "سطح دسترسی",ParentId = 2},
                new (){PermissionId = 4,PermissionTitle = "افزودن سطح دسترسی",ParentId = 3},
                new (){PermissionId = 5,PermissionTitle = "ویرایش سطح دسترسی",ParentId = 3},
                new (){PermissionId = 6,PermissionTitle = "حذف سطح دسترسی",ParentId = 3},

                new (){PermissionId = 7,PermissionTitle = "کاربران",ParentId = 2},
                new (){PermissionId = 8,PermissionTitle = "افزودن کاربران",ParentId = 7},
                new (){PermissionId = 9,PermissionTitle = "ویرایش کاربران",ParentId = 7},
                new (){PermissionId = 10,PermissionTitle = "حذف کاربران",ParentId = 7},

                new (){PermissionId = 11,PermissionTitle = "فروشگاه",ParentId = null},
                new (){PermissionId = 12,PermissionTitle = "گروه کالا",ParentId = 11},
                new (){PermissionId = 13,PermissionTitle = "افزودن گروه کالا",ParentId = 12},
                new (){PermissionId = 14,PermissionTitle = "ویرایش گروه کالا",ParentId = 12},
                new (){PermissionId = 15,PermissionTitle = "حذف گروه کالا",ParentId = 12},


                new(){PermissionId = 16,PermissionTitle = "پارامتر کالا",ParentId = 11},
                new (){PermissionId = 17,PermissionTitle = "افزودن پارامتر کالا",ParentId = 16},
                new (){PermissionId = 18,PermissionTitle = "ویرایش پارامتر کالا",ParentId = 16},
                new (){PermissionId = 19,PermissionTitle = "حذف پارامتر کالا",ParentId = 16},
                
                new (){PermissionId = 20,PermissionTitle = "مقادیر پارامتر کالا",ParentId = 16},
                new (){PermissionId = 21,PermissionTitle = "افزودن مقادیر پارامتر کالا",ParentId = 20},
                new (){PermissionId = 22,PermissionTitle = "ویرایش مقادیر پارامتر کالا",ParentId = 20},
                new (){PermissionId = 23,PermissionTitle = "حذف مقادیر پارامتر کالا",ParentId = 20},

                new (){PermissionId = 24,PermissionTitle = "کالا",ParentId = 11},
                new (){PermissionId = 25,PermissionTitle = "افزودن کالا",ParentId = 24},
                new (){PermissionId = 26,PermissionTitle = "ویرایش کالا",ParentId = 24},
                new (){PermissionId = 27,PermissionTitle = "حذف کالا",ParentId = 24},

                new (){PermissionId = 28,PermissionTitle = "برند کالا",ParentId = 11},
                new (){PermissionId = 29,PermissionTitle = "افزودن برند کالا",ParentId = 28},
                new (){PermissionId = 30,PermissionTitle = "ویرایش برند کالا",ParentId = 28},
                new (){PermissionId = 31,PermissionTitle = "حذف برند کالا",ParentId = 28},

                new (){PermissionId = 32,PermissionTitle = "گالری کالا",ParentId = 24},
                new (){PermissionId = 33,PermissionTitle = "افزودن گالری کالا",ParentId = 32},
                new (){PermissionId = 34,PermissionTitle = "ویرایش گالری کالا",ParentId = 32},
                new (){PermissionId = 35,PermissionTitle = "حذف گالری کالا",ParentId = 32},

                new (){PermissionId = 36,PermissionTitle = "اسلایدر",ParentId = 2},
                new (){PermissionId = 37,PermissionTitle = "افزودن اسلایدر",ParentId = 36},
                new (){PermissionId = 38,PermissionTitle = "ویرایش اسلایدر",ParentId = 36},
                new (){PermissionId = 39,PermissionTitle = "حذف اسلایدر",ParentId = 36},

            });
        }
    }
}