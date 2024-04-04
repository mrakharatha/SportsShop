using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsShop.Infra.Data.Migrations
{
    public partial class ChangeTblBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrandImage",
                table: "Brands",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true);

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "ParentId", "PermissionTitle" },
                values: new object[] { 32, 24, "گالری کالا" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "ParentId", "PermissionTitle" },
                values: new object[] { 33, 32, "افزودن گالری کالا" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "ParentId", "PermissionTitle" },
                values: new object[] { 34, 32, "ویرایش گالری کالا" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "ParentId", "PermissionTitle" },
                values: new object[] { 35, 32, "حذف گالری کالا" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 32);

            migrationBuilder.DropColumn(
                name: "BrandImage",
                table: "Brands");
        }
    }
}
