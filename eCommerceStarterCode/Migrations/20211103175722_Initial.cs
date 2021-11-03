using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a85197de-2346-492e-861e-08b0370b485f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BMPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sodium = table.Column<double>(type: "float", nullable: false),
                    Potassium = table.Column<double>(type: "float", nullable: false),
                    Glucose = table.Column<double>(type: "float", nullable: false),
                    Calcium = table.Column<double>(type: "float", nullable: false),
                    Chloride = table.Column<double>(type: "float", nullable: false),
                    Bicarbonate = table.Column<double>(type: "float", nullable: false),
                    Creatinine = table.Column<double>(type: "float", nullable: false),
                    BUN = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMPs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CBCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rbc = table.Column<double>(type: "float", nullable: false),
                    Hb = table.Column<double>(type: "float", nullable: false),
                    Hct = table.Column<double>(type: "float", nullable: false),
                    MCV = table.Column<double>(type: "float", nullable: false),
                    MCH = table.Column<double>(type: "float", nullable: false),
                    MCHC = table.Column<double>(type: "float", nullable: false),
                    RDW = table.Column<double>(type: "float", nullable: false),
                    WBC = table.Column<double>(type: "float", nullable: false),
                    Neu = table.Column<double>(type: "float", nullable: false),
                    Lym = table.Column<double>(type: "float", nullable: false),
                    Mon = table.Column<double>(type: "float", nullable: false),
                    Eos = table.Column<double>(type: "float", nullable: false),
                    Bas = table.Column<double>(type: "float", nullable: false),
                    Plt = table.Column<double>(type: "float", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBCs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Race = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BMPLists",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BMPId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BMPLists", x => new { x.UserId, x.BMPId });
                    table.ForeignKey(
                        name: "FK_BMPLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BMPLists_BMPs_BMPId",
                        column: x => x.BMPId,
                        principalTable: "BMPs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CBCLists",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CBCId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBCLists", x => new { x.UserId, x.CBCId });
                    table.ForeignKey(
                        name: "FK_CBCLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CBCLists_CBCs_CBCId",
                        column: x => x.CBCId,
                        principalTable: "CBCs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConditionLists",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConditionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConditionLists", x => new { x.UserId, x.ConditionId });
                    table.ForeignKey(
                        name: "FK_ConditionLists_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConditionLists_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b50a8be4-3350-4bf7-8ce4-f5ebe64c1cfb", "e132312d-67cf-47de-a658-fe00b37b74cd", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22ff8df4-03fb-46eb-bcb0-a4d78426eceb", "c00a3b5f-0530-442e-8b3b-6423484ad207", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_BMPLists_BMPId",
                table: "BMPLists",
                column: "BMPId");

            migrationBuilder.CreateIndex(
                name: "IX_CBCLists_CBCId",
                table: "CBCLists",
                column: "CBCId");

            migrationBuilder.CreateIndex(
                name: "IX_ConditionLists_ConditionId",
                table: "ConditionLists",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Profiles_UserId",
                table: "Profiles",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BMPLists");

            migrationBuilder.DropTable(
                name: "CBCLists");

            migrationBuilder.DropTable(
                name: "ConditionLists");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "BMPs");

            migrationBuilder.DropTable(
                name: "CBCs");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ff8df4-03fb-46eb-bcb0-a4d78426eceb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b50a8be4-3350-4bf7-8ce4-f5ebe64c1cfb");

            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0", "df8961da-91f7-4729-a4aa-312b6fcd7c8f", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a85197de-2346-492e-861e-08b0370b485f", "27e54b6b-7578-4229-8a3e-7a5a5651df3b", "Admin", "ADMIN" });
        }
    }
}
