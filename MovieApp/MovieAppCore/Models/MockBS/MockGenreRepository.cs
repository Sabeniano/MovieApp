using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.Models.MockBS
{
    public class MockGenreRepository : IGenreRepository
    {
        public IEnumerable<Genres> Genres
        {
            get
            {
                return new List<Genres>
                {
                    new Genres { GenreId = 1, Genre = "Comedy" },
                    new Genres { GenreId = 2, Genre = "Horror" },
                    new Genres { GenreId = 3, Genre = "Romance" },
                    new Genres { GenreId = 4, Genre = "Action" },
                };
            }
        }
    }
}
