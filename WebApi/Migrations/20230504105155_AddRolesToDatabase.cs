using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi.Migrations
{
    public partial class AddRolesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6f5d44bb-1c4c-41dd-a956-53b9ef8f411c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac8b9a38-23c1-412a-b5bf-50d3270c3851");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e5691143-e52d-4971-b06d-f06e90d511a5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2312a6db-858f-41a7-97f8-1f377ed60daa", "0a0715c7-d736-46f6-a878-c221fa21b379", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "26b019e2-fd6b-433b-bc36-11bcb847cce5", "88e36a48-3695-4154-ae6d-8fc4ae853db3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2bc4821e-b24a-49b5-ab9a-dceae4ac9405", "4d8a991e-2ba5-4130-bedb-fb4c20ad0521", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2312a6db-858f-41a7-97f8-1f377ed60daa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26b019e2-fd6b-433b-bc36-11bcb847cce5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bc4821e-b24a-49b5-ab9a-dceae4ac9405");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6f5d44bb-1c4c-41dd-a956-53b9ef8f411c", "eeb9ff70-36f2-46b7-9e05-0b6e668c5037", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac8b9a38-23c1-412a-b5bf-50d3270c3851", "d1aa5edd-5a87-4a39-b341-50f9b29d262a", "Iser", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e5691143-e52d-4971-b06d-f06e90d511a5", "de7e653d-f945-4994-a149-b763c51854e1", "Admin", "ADMIN" });
        }
    }
}
