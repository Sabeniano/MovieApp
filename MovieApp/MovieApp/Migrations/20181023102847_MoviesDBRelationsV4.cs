using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class MoviesDBRelationsV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_MovieActor_MovieActorsMovieId_MovieActorsActorId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_MovieGenre_MovieGenresMovieId_MovieGenresGenreId",
                table: "MovieGenre");

            migrationBuilder.DropIndex(
                name: "IX_MovieGenre_MovieGenresMovieId_MovieGenresGenreId",
                table: "MovieGenre");

            migrationBuilder.DropIndex(
                name: "IX_MovieActor_MovieActorsMovieId_MovieActorsActorId",
                table: "MovieActor");

            migrationBuilder.DropColumn(
                name: "MovieGenresGenreId",
                table: "MovieGenre");

            migrationBuilder.DropColumn(
                name: "MovieGenresMovieId",
                table: "MovieGenre");

            migrationBuilder.DropColumn(
                name: "MovieActorsActorId",
                table: "MovieActor");

            migrationBuilder.DropColumn(
                name: "MovieActorsMovieId",
                table: "MovieActor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MovieGenresGenreId",
                table: "MovieGenre",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieGenresMovieId",
                table: "MovieGenre",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieActorsActorId",
                table: "MovieActor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MovieActorsMovieId",
                table: "MovieActor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenre_MovieGenresMovieId_MovieGenresGenreId",
                table: "MovieGenre",
                columns: new[] { "MovieGenresMovieId", "MovieGenresGenreId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActor_MovieActorsMovieId_MovieActorsActorId",
                table: "MovieActor",
                columns: new[] { "MovieActorsMovieId", "MovieActorsActorId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_MovieActor_MovieActorsMovieId_MovieActorsActorId",
                table: "MovieActor",
                columns: new[] { "MovieActorsMovieId", "MovieActorsActorId" },
                principalTable: "MovieActor",
                principalColumns: new[] { "MovieId", "ActorId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_MovieGenre_MovieGenresMovieId_MovieGenresGenreId",
                table: "MovieGenre",
                columns: new[] { "MovieGenresMovieId", "MovieGenresGenreId" },
                principalTable: "MovieGenre",
                principalColumns: new[] { "MovieId", "GenreId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
