using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieAppCore.Models
{
    public class Movies
    {
        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset ReleaseDate { get; set; }
        public TimeSpan RunTime { get; set; }

        public string ImageUrl { get; set; }
        public int? GenreId { get; set; }
        public Directors Directors { get; set; }
        public int? DirectorId { get; set; }
        public int? ActorId { get; set; }

        public MovieActors MovieActor { get; set; }
        public MovieGenres MovieGenre { get; set; }
    }
}
