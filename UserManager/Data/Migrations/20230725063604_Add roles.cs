using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManager.Data.Migrations
{
    public partial class Addroles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "001209dd-aa06-4a71-8cdc-7450f9746ef1", "247f6bf7-3745-4a58-936f-af1970ea88e3", "Moderator", "MODERATOR" },
                    { "00b7c29f-0a8d-4e31-8e09-dd9f3dd36ad4", "2a2ae88e-e434-4b9d-8353-8f50d48dea89", "SuperAdmin", "SUPERADMIN" },
                    { "9a08531b-2120-41d5-b3d3-30bd66ed86c8", "f36a91b4-cf7c-4c5e-8e63-c6589604025f", "User", "USER" },
                    { "b73f486b-8f7d-463f-91e4-20eb4ab41e9c", "2d4899a7-5da2-4de5-9e38-e769e619a452", "Admin", "ADMIN" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "001209dd-aa06-4a71-8cdc-7450f9746ef1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00b7c29f-0a8d-4e31-8e09-dd9f3dd36ad4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a08531b-2120-41d5-b3d3-30bd66ed86c8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b73f486b-8f7d-463f-91e4-20eb4ab41e9c");
        }
    }
}
