using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class MoviesDBRelationsV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Actors_ActorsId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Movies_MoviesId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_MovieActor_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Genres_GenresId",
                table: "MovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Movies_MoviesId",
                table: "MovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_MovieGenre_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenre");

            migrationBuilder.RenameColumn(
                name: "MovieGenresMoviesId",
                table: "MovieGenre",
                newName: "MovieGenresMovieId");

            migrationBuilder.RenameColumn(
                name: "MovieGenresGenresId",
                table: "MovieGenre",
                newName: "MovieGenresGenreId");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "MovieGenre",
                newName: "GenreId");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MovieGenre",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenre_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenre",
                newName: "IX_MovieGenre_MovieGenresMovieId_MovieGenresGenreId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenre_GenresId",
                table: "MovieGenre",
                newName: "IX_MovieGenre_GenreId");

            migrationBuilder.RenameColumn(
                name: "MovieActorsMoviesId",
                table: "MovieActor",
                newName: "MovieActorsMovieId");

            migrationBuilder.RenameColumn(
                name: "MovieActorsActorsId",
                table: "MovieActor",
                newName: "MovieActorsActorId");

            migrationBuilder.RenameColumn(
                name: "ActorsId",
                table: "MovieActor",
                newName: "ActorId");

            migrationBuilder.RenameColumn(
                name: "MoviesId",
                table: "MovieActor",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActor",
                newName: "IX_MovieActor_MovieActorsMovieId_MovieActorsActorId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_ActorsId",
                table: "MovieActor",
                newName: "IX_MovieActor_ActorId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Actors_ActorId",
                table: "MovieActor",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Movies_MovieId",
                table: "MovieActor",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_MovieActor_MovieActorsMovieId_MovieActorsActorId",
                table: "MovieActor",
                columns: new[] { "MovieActorsMovieId", "MovieActorsActorId" },
                principalTable: "MovieActor",
                principalColumns: new[] { "MovieId", "ActorId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Genres_GenreId",
                table: "MovieGenre",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Movies_MovieId",
                table: "MovieGenre",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_MovieGenre_MovieGenresMovieId_MovieGenresGenreId",
                table: "MovieGenre",
                columns: new[] { "MovieGenresMovieId", "MovieGenresGenreId" },
                principalTable: "MovieGenre",
                principalColumns: new[] { "MovieId", "GenreId" },
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Actors_ActorId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_Movies_MovieId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActor_MovieActor_MovieActorsMovieId_MovieActorsActorId",
                table: "MovieActor");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Genres_GenreId",
                table: "MovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_Movies_MovieId",
                table: "MovieGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenre_MovieGenre_MovieGenresMovieId_MovieGenresGenreId",
                table: "MovieGenre");

            migrationBuilder.RenameColumn(
                name: "MovieGenresMovieId",
                table: "MovieGenre",
                newName: "MovieGenresMoviesId");

            migrationBuilder.RenameColumn(
                name: "MovieGenresGenreId",
                table: "MovieGenre",
                newName: "MovieGenresGenresId");

            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "MovieGenre",
                newName: "GenresId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "MovieGenre",
                newName: "MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenre_MovieGenresMovieId_MovieGenresGenreId",
                table: "MovieGenre",
                newName: "IX_MovieGenre_MovieGenresMoviesId_MovieGenresGenresId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenre_GenreId",
                table: "MovieGenre",
                newName: "IX_MovieGenre_GenresId");

            migrationBuilder.RenameColumn(
                name: "MovieActorsMovieId",
                table: "MovieActor",
                newName: "MovieActorsMoviesId");

            migrationBuilder.RenameColumn(
                name: "MovieActorsActorId",
                table: "MovieActor",
                newName: "MovieActorsActorsId");

            migrationBuilder.RenameColumn(
                name: "ActorId",
                table: "MovieActor",
                newName: "ActorsId");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "MovieActor",
                newName: "MoviesId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_MovieActorsMovieId_MovieActorsActorId",
                table: "MovieActor",
                newName: "IX_MovieActor_MovieActorsMoviesId_MovieActorsActorsId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_ActorId",
                table: "MovieActor",
                newName: "IX_MovieActor_ActorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Actors_ActorsId",
                table: "MovieActor",
                column: "ActorsId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_Movies_MoviesId",
                table: "MovieActor",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActor_MovieActor_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActor",
                columns: new[] { "MovieActorsMoviesId", "MovieActorsActorsId" },
                principalTable: "MovieActor",
                principalColumns: new[] { "MoviesId", "ActorsId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Genres_GenresId",
                table: "MovieGenre",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_Movies_MoviesId",
                table: "MovieGenre",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenre_MovieGenre_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenre",
                columns: new[] { "MovieGenresMoviesId", "MovieGenresGenresId" },
                principalTable: "MovieGenre",
                principalColumns: new[] { "MoviesId", "GenresId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
