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
                        new Movies { Title = "Movie", Description = "Description", RunTime = TimeSpan.FromMinutes(0), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNiNWQ5M2MtNGI0OC00MDA2LWI5NzEtMmZiYjVjMDEyOWYzXkEyXkFqcGdeQXVyMjM4NTM5NDY@._V1_SY1000_CR0,0,674,1000_AL_.jpg" }
                    );
                }
                context.SaveChanges();

                if (!context.MovieGenre.Any())
                {
                    context.AddRange
                    (
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
