using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDb.Migrations
{
    public partial class AddCast : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cast",
                columns: table => new
                {
                    CastId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CastName = table.Column<string>(type: "TEXT", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cast", x => x.CastId);
                    table.ForeignKey(
                        name: "FK_Cast_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cast_MovieId",
                table: "Cast",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cast");
        }
    }
}
