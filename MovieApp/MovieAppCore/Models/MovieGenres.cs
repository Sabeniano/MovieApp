using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppCore.Models
{
    public class MovieGenres
    {
        public int MovieId { get; set; }
        public Movies Movies { get; set; }

        public int GenreId { get; set; }
        public Genres Genres { get; set; }
    }
}
