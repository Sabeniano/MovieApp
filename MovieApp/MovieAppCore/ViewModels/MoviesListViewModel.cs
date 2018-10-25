using MovieAppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.ViewModels
{
    public class MoviesListViewModel
    {
        public IEnumerable<Movies> Movies { get; set; }
        public string CurrentGenre { get; set; }
    }
}
