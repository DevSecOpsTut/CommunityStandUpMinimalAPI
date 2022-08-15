using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieDb.Migrations
{
    public partial class AddCastNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cast_Movies_MovieId",
                table: "Cast");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cast",
                table: "Cast");

            migrationBuilder.RenameTable(
                name: "Cast",
                newName: "Casts");

            migrationBuilder.RenameIndex(
                name: "IX_Cast_MovieId",
                table: "Casts",
                newName: "IX_Casts_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Casts",
                table: "Casts",
                column: "CastId");

            migrationBuilder.AddForeignKey(
                name: "FK_Casts_Movies_MovieId",
                table: "Casts",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Casts_Movies_MovieId",
                table: "Casts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Casts",
                table: "Casts");

            migrationBuilder.RenameTable(
                name: "Casts",
                newName: "Cast");

            migrationBuilder.RenameIndex(
                name: "IX_Casts_MovieId",
                table: "Cast",
                newName: "IX_Cast_MovieId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cast",
                table: "Cast",
                column: "CastId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cast_Movies_MovieId",
                table: "Cast",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId");
        }
    }
}
