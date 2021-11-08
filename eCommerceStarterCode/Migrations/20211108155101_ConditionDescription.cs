using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class ConditionDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ff8df4-03fb-46eb-bcb0-a4d78426eceb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b50a8be4-3350-4bf7-8ce4-f5ebe64c1cfb");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionExtended",
                table: "Conditions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bba7eb09-959e-4f22-82fe-0126c8dd4134", "67c0e665-f4c2-4c24-8666-29582d1fc4c3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "81e34252-c9b1-4164-b184-7ed2fe7e11db", "a54e5586-bb2d-40f4-8350-1e1dd18342d9", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81e34252-c9b1-4164-b184-7ed2fe7e11db");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bba7eb09-959e-4f22-82fe-0126c8dd4134");

            migrationBuilder.DropColumn(
                name: "DescriptionExtended",
                table: "Conditions");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b50a8be4-3350-4bf7-8ce4-f5ebe64c1cfb", "e132312d-67cf-47de-a658-fe00b37b74cd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22ff8df4-03fb-46eb-bcb0-a4d78426eceb", "c00a3b5f-0530-442e-8b3b-6423484ad207", "Admin", "ADMIN" });
        }
    }
}
