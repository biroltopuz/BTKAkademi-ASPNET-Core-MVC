using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class IdentityRoleSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69707641-d52d-4a13-b9b0-06ca6db2b7a9", "972e3595-cc33-4af7-96a9-bfa7ce2df6af", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9f1055db-c36f-4bc5-b792-0d7482f4c1ad", "a31ce800-c429-482f-a2ce-e482d5925d94", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d6099377-ab91-441d-9d49-0cfe717fd7c0", "faa5aeb3-c4c9-4ef9-849b-d32c52575ea4", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69707641-d52d-4a13-b9b0-06ca6db2b7a9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f1055db-c36f-4bc5-b792-0d7482f4c1ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6099377-ab91-441d-9d49-0cfe717fd7c0");
        }
    }
}
