using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieAppCore.Models;

namespace MovieAppCore.Models
{

    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context =
                serviceScope.ServiceProvider.GetService<MoviesDbContext>();

                if (!context.Genres.Any())
                {
                    context.Genres.AddRange(Genres.Select(c => c.Value));
                }

                if (!context.Movies.Any())
                {
                    context.AddRange
                    (
                        new Movies { Title = "The Shape of Water", Description = "At a top secret research facility in the 1960s, a lonely janitor forms a unique relationship with an amphibious creature that is being held in captivity.", RunTime = TimeSpan.FromMinutes(123), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNiNWQ5M2MtNGI0OC00MDA2LWI5NzEtMmZiYjVjMDEyOWYzXkEyXkFqcGdeQXVyMjM4NTM5NDY@._V1_SY1000_CR0,0,674,1000_AL_.jpg" },
                        new Movies { Title = "Moonlight", Description = "A chronicle of the childhood, adolescence and burgeoning adulthood of a young, African-American, gay man growing up in a rough neighborhood of Miami.", RunTime = TimeSpan.FromMinutes(111), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzQxNTIyODAxMV5BMl5BanBnXkFtZTgwNzQyMDA3OTE@._V1_SY1000_CR0,0,674,1000_AL_.jpg" },
                        new Movies { Title = "Spotlight", Description = "The true story of how the Boston Globe uncovered the massive scandal of child molestation and cover-up within the local Catholic Archdiocese, shaking the entire Catholic Church to its core.", RunTime = TimeSpan.FromMinutes(129), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjIyOTM5OTIzNV5BMl5BanBnXkFtZTgwMDkzODE2NjE@._V1_SY1000_CR0,0,676,1000_AL_.jpg" },
                        new Movies { Title = "Birdman", Description = "A washed-up superhero actor attempts to revive his fading career by writing, directing, and starring in a Broadway production.", RunTime = TimeSpan.FromMinutes(119), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BODAzNDMxMzAxOV5BMl5BanBnXkFtZTgwMDMxMjA4MjE@._V1_SY1000_CR0,0,674,1000_AL_.jpg" },
                        new Movies { Title = "12 Years a Slave", Description = "In the antebellum United States, Solomon Northup, a free black man from upstate New York, is abducted and sold into slavery.", RunTime = TimeSpan.FromMinutes(134), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BZjFkOGNjZjAtMzZjNS00ZjI2LTkwNjEtOWQ3NzQzOTBlMDA5XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_SX675_AL_.jpg" },
                        new Movies { Title = "Operation Argo", Description = "Acting under the cover of a Hollywood producer scouting a location for a science fiction film, a CIA agent launches a dangerous operation to rescue six Americans in Tehran during the U.S. hostage crisis in Iran in 1979.", RunTime = TimeSpan.FromMinutes(120), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNzljNjY3MDYtYzc0Ni00YjU0LWIyNDUtNTE0ZDRiMGExMjZlXkEyXkFqcGdeQXVyMTMxODk2OTU@._V1_SY1000_SX675_AL_.jpg" },
                        new Movies { Title = "The Artist", Description = "An egomaniacal film star develops a relationship with a young dancer against the backdrop of Hollywood's silent era.", RunTime = TimeSpan.FromMinutes(120), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BMDUyZWU5N2UtOWFlMy00MTI0LTk0ZDYtMzFhNjljODBhZDA5XkEyXkFqcGdeQXVyNzA4ODc3ODU@._V1_.jpg" },
                        new Movies { Title = "The King's Speech", Description = "The story of King George VI of the United Kingdom of Great Britain and Northern Ireland, his impromptu ascension to the throne and the speech therapist who helped the unsure monarch become worthy of it.", RunTime = TimeSpan.FromMinutes(118), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BMzU5MjEwMTg2Nl5BMl5BanBnXkFtZTcwNzM3MTYxNA@@._V1_SY1000_CR0,0,684,1000_AL_.jpg" },
                        new Movies { Title = "Slumdog Millionair", Description = "A Mumbai teen reflects on his upbringing in the slums when he is accused of cheating on the Indian Version of Who Wants to be a Millionaire ?", RunTime = TimeSpan.FromMinutes(120), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BZmNjZWI3NzktYWI1Mi00OTAyLWJkNTYtMzUwYTFlZDA0Y2UwXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SY1000_CR0,0,675,1000_AL_.jpg" },
                        new Movies { Title = "The Hurt Locker", Description = "During the Iraq War, a Sergeant recently assigned to an army bomb squad is put at odds with his squad mates due to his maverick way of handling his work.", RunTime = TimeSpan.FromMinutes(131), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BYWYxZjU2MmQtMmMzYi00ZWUwLTg2ZWQtMDExZTVlYjM3ZWM1XkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SY1000_CR0,0,666,1000_AL_.jpg" },
                        new Movies { Title = "No Country for Old Men", Description = "Violence and mayhem ensue after a hunter stumbles upon a drug deal gone wrong and more than two million dollars in cash near the Rio Grande.", RunTime = TimeSpan.FromMinutes(122), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BMjA5Njk3MjM4OV5BMl5BanBnXkFtZTcwMTc5MTE1MQ@@._V1_.jpg" }
                    );
                }
                context.SaveChanges();

                if (!context.MovieGenre.Any())
                {
                    context.AddRange
                    (
                        new MovieGenres { MovieId = 1, GenreId = 3 },
                        new MovieGenres { MovieId = 1, GenreId = 6 },
                        new MovieGenres { MovieId = 1, GenreId = 9 },

                        new MovieGenres { MovieId = 2, GenreId = 6 },

                        new MovieGenres { MovieId = 3, GenreId = 6 },

                        new MovieGenres { MovieId = 4, GenreId = 6 },

                        new MovieGenres { MovieId = 5, GenreId = 1 },
                        new MovieGenres { MovieId = 5, GenreId = 7 },

                        new MovieGenres { MovieId = 6, GenreId = 2 },
                        new MovieGenres { MovieId = 6, GenreId = 6 },
                        new MovieGenres { MovieId = 6, GenreId = 3 },

                        new MovieGenres { MovieId = 7, GenreId = 6 },
                        new MovieGenres { MovieId = 7, GenreId = 8 },

                        new MovieGenres { MovieId = 8, GenreId = 6 },
                        new MovieGenres { MovieId = 8, GenreId = 3 },

                        new MovieGenres { MovieId = 9, GenreId = 6 },
                        new MovieGenres { MovieId = 9, GenreId = 7 },

                        new MovieGenres { MovieId = 10, GenreId = 6 },
                        new MovieGenres { MovieId = 10, GenreId = 7 }
                    );
                }
            }
        }

        private static Dictionary<string, Genres> genres;
        public static Dictionary<string, Genres> Genres
        {
            get
            {
                if (genres == null)
                {
                    var genresList = new Genres[]
                    {
                        new Genres { Genre = "Action" },    //1
                        new Genres { Genre = "Comedy" },    //2
                        new Genres { Genre = "Romance" },   //3
                        new Genres { Genre = "Horror" },    //4
                        new Genres { Genre = "Sci-fi" },    //5
                        new Genres { Genre = "Drama" },     //6
                        new Genres { Genre = "Thriller" },  //7
                        new Genres { Genre = "History" },   //8
                        new Genres { Genre = "Fantasy" },   //9
                        new Genres { Genre = "Adventure" }  //10
                    };

                    genres = new Dictionary<string, Genres>();

                    foreach (Genres genre in genresList)
                    {
                        genres.Add(genre.Genre, genre);
                    }
                }

                return genres;
            }
        }
    }
}
