using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektniZadatak.Migrations
{
    /// <inheritdoc />
    public partial class PrvaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Korisnici_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Objave",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Objave", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Objave_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Komentari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tekst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    objavaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Komentari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Komentari_Objave_objavaId",
                        column: x => x.objavaId,
                        principalTable: "Objave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lajkovi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObjavaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lajkovi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lajkovi_Objave_ObjavaId",
                        column: x => x.ObjavaId,
                        principalTable: "Objave",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Komentari_objavaId",
                table: "Komentari",
                column: "objavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Korisnici_KorisnikId",
                table: "Korisnici",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Lajkovi_ObjavaId",
                table: "Lajkovi",
                column: "ObjavaId");

            migrationBuilder.CreateIndex(
                name: "IX_Objave_KorisnikId",
                table: "Objave",
                column: "KorisnikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Komentari");

            migrationBuilder.DropTable(
                name: "Lajkovi");

            migrationBuilder.DropTable(
                name: "Objave");

            migrationBuilder.DropTable(
                name: "Korisnici");
        }
    }
}
