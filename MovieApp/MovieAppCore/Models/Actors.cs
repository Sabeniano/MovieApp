using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieAppCore.Models
{
    public class Actors
    {
        [Key]
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public string ImageUrl { get; set; }
        public IList<MovieActors> MovieActor { get; set; }
    }
}
