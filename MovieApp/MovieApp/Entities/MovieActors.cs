using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Entities
{
    public class MovieActors
    {
        public int MovieId { get; set; }
        public Movies Movies { get; set; }

        public int ActorId { get; set; }
        public Actors Actors { get; set; }
    }
}
