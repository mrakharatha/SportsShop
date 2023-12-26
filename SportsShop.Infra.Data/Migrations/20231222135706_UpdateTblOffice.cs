using Microsoft.EntityFrameworkCore.Migrations;

namespace SportsShop.Infra.Data.Migrations
{
    public partial class UpdateTblOffice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telegram",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Threads",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WhatsApp",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YouTube",
                table: "Offices",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Telegram",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "Threads",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "WhatsApp",
                table: "Offices");

            migrationBuilder.DropColumn(
                name: "YouTube",
                table: "Offices");
        }
    }
}
