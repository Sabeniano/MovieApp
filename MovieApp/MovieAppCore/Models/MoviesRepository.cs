using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.Models
{
    public class MoviesRepository : IMovieRepository
    {
        private readonly MoviesDbContext _moviesDbContext;
        public MoviesRepository(MoviesDbContext moviesDbContext)
        {
            _moviesDbContext = moviesDbContext;
        }

        public IEnumerable<Movies> Movies
        {
            get
            {
                return _moviesDbContext.Movies.Include(mg => mg.MovieGenre).ThenInclude(g => g.Genres).ToList();
            }
        }

        public Movies GetMovieById(int movieId)
        {
            return _moviesDbContext.Movies.FirstOrDefault(p => p.MovieId == movieId);
        }
    }
}
