using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.Models
{
    public interface IMovieRepository
    {
        IEnumerable<Movies> Movies { get;  }
        Movies GetMovieById(int movieId);
    }
}
