using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsShop.Infra.Data.Migrations
{
    public partial class UpdatePermission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 11,
                columns: new[] { "ParentId", "PermissionTitle" },
                values: new object[] { null, "فروشگاه" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 12,
                column: "PermissionTitle",
                value: "گروه کالا");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 13,
                columns: new[] { "ParentId", "PermissionTitle" },
                values: new object[] { 12, "افزودن گروه کالا" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 14,
                columns: new[] { "ParentId", "PermissionTitle" },
                values: new object[] { 12, "ویرایش گروه کالا" });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "PermissionId", "ParentId", "PermissionTitle" },
                values: new object[,]
                {
                    { 7, 2, "کاربران" },
                    { 8, 11, "افزودن کاربران" },
                    { 9, 11, "ویرایش کاربران" },
                    { 10, 11, "حذف کاربران" },
                    { 15, 12, "حذف گروه کالا" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 11,
                columns: new[] { "ParentId", "PermissionTitle" },
                values: new object[] { 2, "کاربران" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 12,
                column: "PermissionTitle",
                value: "افزودن کاربران");

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 13,
                columns: new[] { "ParentId", "PermissionTitle" },
                values: new object[] { 11, "ویرایش کاربران" });

            migrationBuilder.UpdateData(
                table: "Permissions",
                keyColumn: "PermissionId",
                keyValue: 14,
                columns: new[] { "ParentId", "PermissionTitle" },
                values: new object[] { 11, "حذف کاربران" });
        }
    }
}
