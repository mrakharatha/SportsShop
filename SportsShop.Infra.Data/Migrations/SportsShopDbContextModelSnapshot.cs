﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SportsShop.Infra.Data.Context;

namespace SportsShop.Infra.Data.Migrations
{
    [DbContext(typeof(SportsShopDbContext))]
    partial class SportsShopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            PermissionId = 11,
                            ParentId = 2,
                            PermissionTitle = "کاربران"
                        },
                        new
                        {
                            PermissionId = 12,
                            ParentId = 11,
                            PermissionTitle = "افزودن کاربران"
                        },
                        new
                        {
                            PermissionId = 13,
                            ParentId = 11,
                            PermissionTitle = "ویرایش کاربران"
                        },
                        new
                        {
                            PermissionId = 14,
                            ParentId = 11,
                            PermissionTitle = "حذف کاربران"
                        });
                });

            modelBuilder.Entity("SportsShop.Domain.Models.Permissions.Role", b =>
                {
                    b.Property<int>("RoleId")
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

                    b.Property<string>("RoleTitle")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            CreateDate = new DateTime(2023, 12, 20, 19, 17, 32, 968, DateTimeKind.Local).AddTicks(1379),
                            RoleTitle = "مدیر"
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

            modelBuilder.Entity("SportsShop.Domain.Models.Stores.Office", b =>
                {
                    b.Property<int>("OfficeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteDate")
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

                    b.HasKey("OfficeId");

                    b.HasIndex("UserId");

                    b.ToTable("Offices");

                    b.HasData(
                        new
                        {
                            OfficeId = 1,
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
                    b.Property<int>("UserId")
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

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
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

            modelBuilder.Entity("SportsShop.Domain.Models.Users.User", b =>
                {
                    b.Navigation("Offices");
                });
#pragma warning restore 612, 618
        }
    }
}
