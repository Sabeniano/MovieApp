using System;
using System.Collections.Generic;
using System.Text;

namespace MovieAppCore.Models
{
    public class MovieActors
    {
        public int MovieId { get; set; }
        public Movies Movies { get; set; }

        public int ActorId { get; set; }
        public Actors Actors { get; set; }
    }
}
