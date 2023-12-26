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
    [Migration("20231219170209_SeederPermission")]
    partial class SeederPermission
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

            modelBuilder.Entity("SportsShop.Domain.Models.User.UserRole", b =>
                {
                    b.Property<int>("UserRoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserRoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
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
                        .WithMany("RolePermissionAdmins")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("SportsShop.Domain.Models.User.UserRole", b =>
                {
                    b.HasOne("SportsShop.Domain.Models.Permissions.Role", "Role")
                        .WithMany("UserRoles")
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
                    b.Navigation("RolePermissionAdmins");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}