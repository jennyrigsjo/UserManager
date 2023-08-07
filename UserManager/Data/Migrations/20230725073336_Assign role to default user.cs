using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserManager.Data.Migrations
{
    public partial class Assignroletodefaultuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "0b6f0fa1-ef92-4ab3-8c7a-a11da79d64cc", "0192dc23-6a5e-4635-ba2f-d00c27d9d19f", "Admin", "ADMIN" },
                    { "50881ec0-ee81-4a0b-ae51-b1de066ed909", "504d442b-7fb9-4f85-89fc-7a5bfd389428", "SuperAdmin", "SUPERADMIN" },
                    { "564f25dd-6626-41a9-ba1d-6417f835b43e", "672271c3-13e5-4411-9456-924304b7bc86", "User", "USER" },
                    { "e7eceac0-a473-4836-8dd2-8e8f723f9bb1", "54b9ddc3-8d8c-484d-9fe9-939a84959884", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName", "UsernameChangeLimit" },
                values: new object[] { "96671de6-b753-4124-a778-701ea6a19067", 0, "869c9a9a-d009-4b7f-bc19-29d963458684", "jennyrigsjo@gmail.com", true, "Jenny", "Rigsjö", false, null, "jennyrigsjo@gmail.com", "SUPERADMIN", "AQAAAAEAACcQAAAAEBdHK/LE/NgNeQGY8JERviTb2Q1vAXpsmocN4Dxvn8VURKU2IDYFyZi3okYsMKs4tA==", null, true, null, "9e832867-da23-48ab-8416-5c8bb76b7bd1", false, "superadmin", 10 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "50881ec0-ee81-4a0b-ae51-b1de066ed909", "96671de6-b753-4124-a778-701ea6a19067" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b6f0fa1-ef92-4ab3-8c7a-a11da79d64cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "564f25dd-6626-41a9-ba1d-6417f835b43e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7eceac0-a473-4836-8dd2-8e8f723f9bb1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "50881ec0-ee81-4a0b-ae51-b1de066ed909", "96671de6-b753-4124-a778-701ea6a19067" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "50881ec0-ee81-4a0b-ae51-b1de066ed909");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96671de6-b753-4124-a778-701ea6a19067");

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
    }
}
