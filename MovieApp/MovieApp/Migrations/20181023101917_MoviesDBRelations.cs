using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieApp.Migrations
{
    public partial class MoviesDBRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieActors",
                columns: table => new
                {
                    MoviesId = table.Column<int>(nullable: false),
                    ActorsId = table.Column<int>(nullable: false),
                    MovieActorsActorsId = table.Column<int>(nullable: true),
                    MovieActorsMoviesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieActors", x => new { x.MoviesId, x.ActorsId });
                    table.ForeignKey(
                        name: "FK_MovieActors_Actors_ActorsId",
                        column: x => x.ActorsId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieActors_MovieActors_MovieActorsMoviesId_MovieActorsActorsId",
                        columns: x => new { x.MovieActorsMoviesId, x.MovieActorsActorsId },
                        principalTable: "MovieActors",
                        principalColumns: new[] { "MoviesId", "ActorsId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    MoviesId = table.Column<int>(nullable: false),
                    GenresId = table.Column<int>(nullable: false),
                    MovieGenresGenresId = table.Column<int>(nullable: true),
                    MovieGenresMoviesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.MoviesId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_MovieGenres_MovieGenresMoviesId_MovieGenresGenresId",
                        columns: x => new { x.MovieGenresMoviesId, x.MovieGenresGenresId },
                        principalTable: "MovieGenres",
                        principalColumns: new[] { "MoviesId", "GenresId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_ActorsId",
                table: "MovieActors",
                column: "ActorsId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieActors_MovieActorsMoviesId_MovieActorsActorsId",
                table: "MovieActors",
                columns: new[] { "MovieActorsMoviesId", "MovieActorsActorsId" });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenresId",
                table: "MovieGenres",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_MovieGenresMoviesId_MovieGenresGenresId",
                table: "MovieGenres",
                columns: new[] { "MovieGenresMoviesId", "MovieGenresGenresId" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieActors");

            migrationBuilder.DropTable(
                name: "MovieGenres");
        }
    }
}
