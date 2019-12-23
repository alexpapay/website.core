using Microsoft.EntityFrameworkCore.Migrations;

namespace website.data.Migrations
{
    public partial class DefaultAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62a19e81-5bd2-4f6a-b3f3-21a81de27d4d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3832c0f4-af64-4d7b-a3a7-751d5239fbd9", "e6695b2e-b37b-42e6-aa17-4ac87caaba52", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6450ea59-81b2-4884-997b-51044be06439", "f378ea6e-27eb-4736-9f4d-3ec516ec6b06", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8686a6fe-8e30-4e7d-8013-e3499886daba", 0, "d740303b-ff54-4636-ae5d-57e6deed1286", "admin@email.com", (short)1, (short)0, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAEEj5OsSTVMNfD19LM1lyZuuGaAlGxloj0vtf9QelWP1QZCmXPrbSP0VrGJt+2nyfZA==", "123456789", (short)0, "51fe269a-d702-46e5-b4cc-59558f657ec8", (short)0, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "8686a6fe-8e30-4e7d-8013-e3499886daba", "3832c0f4-af64-4d7b-a3a7-751d5239fbd9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3832c0f4-af64-4d7b-a3a7-751d5239fbd9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6450ea59-81b2-4884-997b-51044be06439");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8686a6fe-8e30-4e7d-8013-e3499886daba");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62a19e81-5bd2-4f6a-b3f3-21a81de27d4d", "ebed5fee-8824-4bfc-b572-7a12837b667d", "Admin", "ADMIN" });
        }
    }
}
