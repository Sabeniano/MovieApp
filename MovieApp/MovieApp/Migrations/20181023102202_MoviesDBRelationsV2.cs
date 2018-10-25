using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class MoviesDBRelationsV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Actors_ActorsId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_Movies_MoviesId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieActors_MovieActors_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActors");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Genres_GenresId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_Movies_MoviesId",
                table: "MovieGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieGenres_MovieGenres_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieGenres",
                table: "MovieGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors");

            migrationBuilder.RenameTable(
                name: "MovieGenres",
                newName: "MovieGenre");

            migrationBuilder.RenameTable(
                name: "MovieActors",
                newName: "MovieActor");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenres_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenre",
                newName: "IX_MovieGenre_MovieGenresMoviesId_MovieGenresGenresId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenres_GenresId",
                table: "MovieGenre",
                newName: "IX_MovieGenre_GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActors_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActor",
                newName: "IX_MovieActor_MovieActorsMoviesId_MovieActorsActorsId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActors_ActorsId",
                table: "MovieActor",
                newName: "IX_MovieActor_ActorsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieGenre",
                table: "MovieGenre",
                columns: new[] { "MoviesId", "GenresId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActor",
                table: "MovieActor",
                columns: new[] { "MoviesId", "ActorsId" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieGenre",
                table: "MovieGenre");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieActor",
                table: "MovieActor");

            migrationBuilder.RenameTable(
                name: "MovieGenre",
                newName: "MovieGenres");

            migrationBuilder.RenameTable(
                name: "MovieActor",
                newName: "MovieActors");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenre_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenres",
                newName: "IX_MovieGenres_MovieGenresMoviesId_MovieGenresGenresId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieGenre_GenresId",
                table: "MovieGenres",
                newName: "IX_MovieGenres_GenresId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActors",
                newName: "IX_MovieActors_MovieActorsMoviesId_MovieActorsActorsId");

            migrationBuilder.RenameIndex(
                name: "IX_MovieActor_ActorsId",
                table: "MovieActors",
                newName: "IX_MovieActors_ActorsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieGenres",
                table: "MovieGenres",
                columns: new[] { "MoviesId", "GenresId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieActors",
                table: "MovieActors",
                columns: new[] { "MoviesId", "ActorsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Actors_ActorsId",
                table: "MovieActors",
                column: "ActorsId",
                principalTable: "Actors",
                principalColumn: "ActorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_Movies_MoviesId",
                table: "MovieActors",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieActors_MovieActors_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActors",
                columns: new[] { "MovieActorsMoviesId", "MovieActorsActorsId" },
                principalTable: "MovieActors",
                principalColumns: new[] { "MoviesId", "ActorsId" },
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Genres_GenresId",
                table: "MovieGenres",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "GenreId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_Movies_MoviesId",
                table: "MovieGenres",
                column: "MoviesId",
                principalTable: "Movies",
                principalColumn: "MovieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieGenres_MovieGenres_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenres",
                columns: new[] { "MovieGenresMoviesId", "MovieGenresGenresId" },
                principalTable: "MovieGenres",
                principalColumns: new[] { "MoviesId", "GenresId" },
                onDelete: ReferentialAction.Restrict);
        }
    }
}
