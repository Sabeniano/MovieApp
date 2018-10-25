using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieAppCore.Models
{
    public class Genres
    {
        [Key]
        public int GenreId { get; set; }
        public string Genre { get; set; }

        public IList<MovieGenres> MovieGenre { get; set; }
    }
}
