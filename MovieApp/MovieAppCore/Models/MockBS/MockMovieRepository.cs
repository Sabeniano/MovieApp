using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.Models.MockBS
{
    public class MockMovieRepository : IMovieRepository
    {
        private readonly IGenreRepository _genreRepository = new MockGenreRepository();
        public IEnumerable<Movies> Movies
        {
            get
            {
                return new List<Movies>
                {
                    new Movies { MovieId = 1, Title = "Scooby DDoo", Description = "Dog Chases Ghosts", RunTime=TimeSpan.FromMinutes(120), ReleaseDate=DateTime.Today, ImageUrl="https://m.media-amazon.com/images/M/MV5BMjIzMDcyMDcxOV5BMl5BanBnXkFtZTgwMTg1NDk2NTM@._V1_.jpg"/*, Genre = _genreRepository.Genres.ToList()[0]*/ },
                    new Movies { MovieId = 2, Title = "The Ring", Description = "Ghost in well", RunTime=TimeSpan.FromMinutes(220), ReleaseDate=DateTime.Today, ImageUrl="https://m.media-amazon.com/images/M/MV5BMjIzMDcyMDcxOV5BMl5BanBnXkFtZTgwMTg1NDk2NTM@._V1_.jpg"},
                    new Movies { MovieId = 3, Title = "Ninja Turtles", Description = "Turtles that are also ninjas", RunTime=TimeSpan.FromMinutes(60), ReleaseDate=DateTime.Today, ImageUrl="https://m.media-amazon.com/images/M/MV5BMjIzMDcyMDcxOV5BMl5BanBnXkFtZTgwMTg1NDk2NTM@._V1_.jpg"},
                    new Movies { MovieId = 4, Title = "The Note Book", Description = "Romance bs", RunTime=TimeSpan.FromMinutes(147), ReleaseDate=DateTime.Today, ImageUrl="https://m.media-amazon.com/images/M/MV5BMjIzMDcyMDcxOV5BMl5BanBnXkFtZTgwMTg1NDk2NTM@._V1_.jpg"},
                };
            }
        }

        public Movies GetMovieById(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
