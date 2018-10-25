using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MovieApp.Entities
{
    public class Directors
    {
        [Key]
        public int DirectorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Movies> Movies { get; set; }
    }
}
