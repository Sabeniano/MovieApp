using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.Models
{
    public class GenreRepository : IGenreRepository
    {
        private readonly MoviesDbContext _moviesDbContext;

        public GenreRepository(MoviesDbContext moviesDbContext)
        {
            _moviesDbContext = moviesDbContext;
        }
        public IEnumerable<Genres> Genres => _moviesDbContext.Genres;
    }

}
