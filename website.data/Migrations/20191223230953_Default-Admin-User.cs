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
                values: new object[] { "98d7cc95-1e7d-4dac-a828-3ccde46447a5", "1c07c806-54ea-4302-9369-03e233f3aee7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8e62a352-a224-46cd-acaa-d93b3130457e", "03e373cd-4caa-46b3-a2da-e43e955fc5bd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b3b6a746-4590-4f8b-98aa-1b2c86832ddf", 0, "dc5dadea-755a-4b9a-84db-cc55c40ab434", "admin@email.com", (short)1, (short)0, null, "ADMIN@EMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAENVcUYRRsMlFTFd1Sdo3IQcuNc41ejdTILt7iI0Z+m66bG8is1D39W/k65wBbTgSyQ==", "123456789", (short)0, "1199d08f-dd65-48ca-a92d-40718c6c117a", (short)0, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e62a352-a224-46cd-acaa-d93b3130457e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98d7cc95-1e7d-4dac-a828-3ccde46447a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3b6a746-4590-4f8b-98aa-1b2c86832ddf");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "62a19e81-5bd2-4f6a-b3f3-21a81de27d4d", "ebed5fee-8824-4bfc-b572-7a12837b667d", "Admin", "ADMIN" });
        }
    }
}
