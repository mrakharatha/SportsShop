﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Migrations
{
    [DbContext(typeof(SportsShopDbContext))]
    [Migration("20240202074744_AddTblBrand")]
    partial class AddTblBrand
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.Permission", b =>
                {
                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<string>("PermissionTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("PermissionId");

                    b.HasIndex("ParentId");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            PermissionId = 1,
                            PermissionTitle = "داشبورد"
                        },
                        new
                        {
                            PermissionId = 2,
                            PermissionTitle = "اطلاعات پایه"
                        },
                        new
                        {
                            PermissionId = 3,
                            ParentId = 2,
                            PermissionTitle = "سطح دسترسی"
                        },
                        new
                        {
                            PermissionId = 4,
                            ParentId = 3,
                            PermissionTitle = "افزودن سطح دسترسی"
                        },
                        new
                        {
                            PermissionId = 5,
                            ParentId = 3,
                            PermissionTitle = "ویرایش سطح دسترسی"
                        },
                        new
                        {
                            PermissionId = 6,
                            ParentId = 3,
                            PermissionTitle = "حذف سطح دسترسی"
                        },
                        new
                        {
                            PermissionId = 7,
                            ParentId = 2,
                            PermissionTitle = "کاربران"
                        },
                        new
                        {
                            PermissionId = 8,
                            ParentId = 7,
                            PermissionTitle = "افزودن کاربران"
                        },
                        new
                        {
                            PermissionId = 9,
                            ParentId = 7,
                            PermissionTitle = "ویرایش کاربران"
                        },
                        new
                        {
                            PermissionId = 10,
                            ParentId = 7,
                            PermissionTitle = "حذف کاربران"
                        },
                        new
                        {
                            PermissionId = 11,
                            PermissionTitle = "فروشگاه"
                        },
                        new
                        {
                            PermissionId = 12,
                            ParentId = 11,
                            PermissionTitle = "گروه کالا"
                        },
                        new
                        {
                            PermissionId = 13,
                            ParentId = 12,
                            PermissionTitle = "افزودن گروه کالا"
                        },
                        new
                        {
                            PermissionId = 14,
                            ParentId = 12,
                            PermissionTitle = "ویرایش گروه کالا"
                        },
                        new
                        {
                            PermissionId = 15,
                            ParentId = 12,
                            PermissionTitle = "حذف گروه کالا"
                        },
                        new
                        {
                            PermissionId = 16,
                            ParentId = 11,
                            PermissionTitle = "پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 17,
                            ParentId = 16,
                            PermissionTitle = "افزودن پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 18,
                            ParentId = 16,
                            PermissionTitle = "ویرایش پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 19,
                            ParentId = 16,
                            PermissionTitle = "حذف پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 20,
                            ParentId = 16,
                            PermissionTitle = "مقادیر پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 21,
                            ParentId = 20,
                            PermissionTitle = "افزودن مقادیر پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 22,
                            ParentId = 20,
                            PermissionTitle = "ویرایش مقادیر پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 23,
                            ParentId = 20,
                            PermissionTitle = "حذف مقادیر پارامتر کالا"
                        },
                        new
                        {
                            PermissionId = 24,
                            ParentId = 11,
                            PermissionTitle = "کالا"
                        },
                        new
                        {
                            PermissionId = 25,
                            ParentId = 24,
                            PermissionTitle = "افزودن کالا"
                        },
                        new
                        {
                            PermissionId = 26,
                            ParentId = 24,
                            PermissionTitle = "ویرایش کالا"
                        },
                        new
                        {
                            PermissionId = 27,
                            ParentId = 24,
                            PermissionTitle = "حذف کالا"
                        },
                        new
                        {
                            PermissionId = 28,
                            ParentId = 11,
                            PermissionTitle = "برند کالا"
                        },
                        new
                        {
                            PermissionId = 29,
                            ParentId = 28,
                            PermissionTitle = "افزودن برند کالا"
                        },
                        new
                        {
                            PermissionId = 30,
                            ParentId = 28,
                            PermissionTitle = "ویرایش برند کالا"
                        },
                        new
                        {
                            PermissionId = 31,
                            ParentId = 28,
                            PermissionTitle = "حذف برند کالا"
                        });
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 12, 20, 19, 17, 32, 968, DateTimeKind.Local).AddTicks(1379),
                            Title = "مدیر"
                        });
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.RolePermission", b =>
                {
                    b.Property<int>("RolePermissionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PermissionId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("RolePermissionId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Parameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.ParameterValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("ParameterId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParameterId");

                    b.HasIndex("UserId");

                    b.ToTable("ParameterValues");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BriefDescription")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoreInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PriceProduct")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("ProductGroupId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("ProductImage")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("SendAndReturn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductGroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.ProductGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int?>("Priority")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.HasIndex("UserId");

                    b.ToTable("ProductGroups");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.ProductParameter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParameterId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParameterId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductParameters");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Stores.Office", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HolidayWorkingHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HolidayWorkingTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Latitude")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Longitude")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalDayWorkingHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalDayWorkingTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telegram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Threads")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YouTube")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "یزد،صفائیه،میدان اطلسی",
                            CreateDate = new DateTime(2023, 12, 20, 19, 17, 32, 968, DateTimeKind.Local).AddTicks(1379),
                            Email = "hosseion4016@gmail.com",
                            HolidayWorkingHours = "11 صبح تا 5 عصر",
                            HolidayWorkingTitle = "پنج شنبه",
                            Name = "فروشگاه ورزشی نقش اسکیت",
                            NormalDayWorkingHours = "11 صبح تا 7 عصر",
                            NormalDayWorkingTitle = "شنبه تا چهارشنبه",
                            PhoneNumber = "09138573151",
                            SiteName = "فروشگاه ورزشی",
                            UserId = 1
                        });
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("RoleId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 12, 20, 19, 23, 0, 0, DateTimeKind.Local).AddTicks(2972),
                            FullName = "سوپر ادمین",
                            Password = "7D-A1-88-C2-E2-D8-3E-38-B7-D9-E7-5E-50-0F-1A-F8",
                            RoleId = 1,
                            UserName = "superadmin"
                        });
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.Permission", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Permissions.Permission", null)
                        .WithMany("Permissions")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.RolePermission", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Permissions.Permission", "Permission")
                        .WithMany("RolePermissionAdmins")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SportsShop.Domain.Models.Permissions.Role", "Role")
                        .WithMany("RolePermissions")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Brand", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Users.User", "User")
                        .WithMany("Brands")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Parameter", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Users.User", "User")
                        .WithMany("Parameters")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.ParameterValue", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Products.Parameter", "Parameter")
                        .WithMany("ParameterValues")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SportsShop.Domain.Models.Users.User", "User")
                        .WithMany("ParameterValues")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Parameter");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Product", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Products.ProductGroup", "ProductGroup")
                        .WithMany("Products")
                        .HasForeignKey("ProductGroupId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SportsShop.Domain.Models.Users.User", "User")
                        .WithMany("Products")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ProductGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.ProductGroup", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Products.ProductGroup", "ParentGroup")
                        .WithMany()
                        .HasForeignKey("ParentId");

                    b.HasOne("SportsShop.Domain.Models.Users.User", "User")
                        .WithMany("ProductGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ParentGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.ProductParameter", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Products.Parameter", "Parameter")
                        .WithMany("ProductParameters")
                        .HasForeignKey("ParameterId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("SportsShop.Domain.Models.Products.Product", "Product")
                        .WithMany("ProductParameters")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Parameter");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Stores.Office", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Users.User", "User")
                        .WithMany("Offices")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Users.User", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Permissions.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.Permission", b =>
                {
                    b.Navigation("Permissions");

                    b.Navigation("RolePermissionAdmins");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.Role", b =>
                {
                    b.Navigation("RolePermissions");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Parameter", b =>
                {
                    b.Navigation("ParameterValues");

                    b.Navigation("ProductParameters");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.Product", b =>
                {
                    b.Navigation("ProductParameters");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Products.ProductGroup", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Users.User", b =>
                {
                    b.Navigation("Brands");

                    b.Navigation("Offices");

                    b.Navigation("Parameters");

                    b.Navigation("ParameterValues");

                    b.Navigation("ProductGroups");

                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
