using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meshur_Sehirler_CF.Migrations
{
    public partial class Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sehirler",
                columns: table => new
                {
                    Plaka = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sehirler", x => x.Plaka);
                });

            migrationBuilder.CreateTable(
                name: "Ozellikler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SehirId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ozellikler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ozellikler_Sehirler_SehirId",
                        column: x => x.SehirId,
                        principalTable: "Sehirler",
                        principalColumn: "Plaka",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Plaka", "Ad" },
                values: new object[] { 21, "Diyarbakır" });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Plaka", "Ad" },
                values: new object[] { 38, "Kayseri" });

            migrationBuilder.InsertData(
                table: "Sehirler",
                columns: new[] { "Plaka", "Ad" },
                values: new object[] { 44, "Malatya" });

            migrationBuilder.InsertData(
                table: "Ozellikler",
                columns: new[] { "Id", "Ad", "SehirId" },
                values: new object[,]
                {
                    { 1, "Karpuz", 21 },
                    { 2, "Kayısı", 44 },
                    { 3, "Mantı", 38 },
                    { 4, "Pastıma", 38 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ozellikler_SehirId",
                table: "Ozellikler",
                column: "SehirId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ozellikler");

            migrationBuilder.DropTable(
                name: "Sehirler");
        }
    }
}
