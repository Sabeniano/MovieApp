using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieApp.Entities
{
    public class Actors
    {
        [Key]
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<MovieActors> MovieActor { get; set; }
    }
}
