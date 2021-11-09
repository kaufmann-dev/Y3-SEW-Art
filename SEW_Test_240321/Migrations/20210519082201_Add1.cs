using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SEW_Test_240321.Migrations
{
    public partial class Add1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ARTISTS",
                columns: table => new
                {
                    ARTIST_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FIRST_NAME = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LAST_NAME = table.Column<string>(type: "VARCHAR(20)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EPOCHE = table.Column<string>(type: "VARCHAR(30)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTISTS", x => x.ARTIST_ID);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "WORK_OF_ART_BT",
                columns: table => new
                {
                    ARTWORK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TITLE = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AESTIMATED_VALUE = table.Column<int>(type: "INT", nullable: false),
                    ARTIST = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WORK_OF_ART_BT", x => x.ARTWORK_ID);
                    table.ForeignKey(
                        name: "FK_WORK_OF_ART_BT_ARTISTS_ARTIST",
                        column: x => x.ARTIST,
                        principalTable: "ARTISTS",
                        principalColumn: "ARTIST_ID",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PAINTING",
                columns: table => new
                {
                    ARTWORK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WIDTH = table.Column<int>(type: "INT", nullable: false),
                    HEIGHT = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PAINTING", x => x.ARTWORK_ID);
                    table.ForeignKey(
                        name: "FK_PAINTING_WORK_OF_ART_BT_ARTWORK_ID",
                        column: x => x.ARTWORK_ID,
                        principalTable: "WORK_OF_ART_BT",
                        principalColumn: "ARTWORK_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SCULPTURE",
                columns: table => new
                {
                    ARTWORK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WEIGHT = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCULPTURE", x => x.ARTWORK_ID);
                    table.ForeignKey(
                        name: "FK_SCULPTURE_WORK_OF_ART_BT_ARTWORK_ID",
                        column: x => x.ARTWORK_ID,
                        principalTable: "WORK_OF_ART_BT",
                        principalColumn: "ARTWORK_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SETUP",
                columns: table => new
                {
                    ARTWORK_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DESCRIPTION = table.Column<string>(type: "VARCHAR(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SETUP", x => x.ARTWORK_ID);
                    table.ForeignKey(
                        name: "FK_SETUP_WORK_OF_ART_BT_ARTWORK_ID",
                        column: x => x.ARTWORK_ID,
                        principalTable: "WORK_OF_ART_BT",
                        principalColumn: "ARTWORK_ID",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_WORK_OF_ART_BT_ARTIST",
                table: "WORK_OF_ART_BT",
                column: "ARTIST");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PAINTING");

            migrationBuilder.DropTable(
                name: "SCULPTURE");

            migrationBuilder.DropTable(
                name: "SETUP");

            migrationBuilder.DropTable(
                name: "WORK_OF_ART_BT");

            migrationBuilder.DropTable(
                name: "ARTISTS");
        }
    }
}
