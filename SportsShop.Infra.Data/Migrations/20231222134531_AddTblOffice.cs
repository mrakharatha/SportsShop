using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsShop.Infra.Data.Migrations
{
    public partial class AddTblOffice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(11)",
                oldMaxLength: 11);

            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalDayWorkingTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NormalDayWorkingHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HolidayWorkingTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HolidayWorkingHours = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Latitude = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.OfficeId);
                    table.ForeignKey(
                        name: "FK_Offices_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "OfficeId", "Address", "CreateDate", "DeleteDate", "Email", "HolidayWorkingHours", "HolidayWorkingTitle", "Latitude", "Logo", "Longitude", "Name", "NormalDayWorkingHours", "NormalDayWorkingTitle", "PhoneNumber", "SiteName", "UpdateDate", "UserId" },
                values: new object[] { 1, "یزد،صفائیه،میدان اطلسی", new DateTime(2023, 12, 20, 19, 17, 32, 968, DateTimeKind.Local).AddTicks(1379), null, "hosseion4016@gmail.com", "11 صبح تا 5 عصر", "پنج شنبه", null, null, null, "فروشگاه ورزشی نقش اسکیت", "11 صبح تا 7 عصر", "شنبه تا چهارشنبه", "09138573151", "فروشگاه ورزشی", null, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Offices_UserId",
                table: "Offices",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offices");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
