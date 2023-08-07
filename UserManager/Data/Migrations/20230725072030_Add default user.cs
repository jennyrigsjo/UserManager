using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManager.Data.Migrations
{
    public partial class Adddefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3c76d330-acfa-43e4-a103-87aaf1b7c0f0", "1990a1fb-9dae-454e-9982-66b1d46e1ee2", "Moderator", "MODERATOR" },
                    { "bb3f2aed-2972-4455-8e67-8035912d443b", "0328f5a9-e7a1-48bf-8a23-0ddd0f447ca8", "User", "USER" },
                    { "d47c3f0f-42f1-4a63-8b78-831e7b74dc2f", "4044a6bc-6fa7-4c46-9fdb-72c7d03df3b4", "Admin", "ADMIN" },
                    { "f003f4c9-2c79-41de-9588-f4d2dfdfe5ab", "b81d9a2e-cc07-4cbd-93ef-66fd1bf35ec1", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "6fec6e33-f58e-4fb1-b086-3436ef771904", 0, "5e9274fb-1d9d-4810-8ef5-4dd76ec4d337", "jennyrigsjo@gmail.com", true, "Jenny", "Rigsjö", false, null, "jennyrigsjo@gmail.com", "SUPERADMIN", "AQAAAAEAACcQAAAAEACOkxX5fFSL7QWqSnX8biaflOG5LZCz1gPzmfDM6Be+haAqI6VPU04cK7NP3+r87Q==", null, true, null, "0777d148-38cb-4f1c-8673-f9e36993039c", false, "superadmin", 10 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3c76d330-acfa-43e4-a103-87aaf1b7c0f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb3f2aed-2972-4455-8e67-8035912d443b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d47c3f0f-42f1-4a63-8b78-831e7b74dc2f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f003f4c9-2c79-41de-9588-f4d2dfdfe5ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fec6e33-f58e-4fb1-b086-3436ef771904");

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
    }
}
