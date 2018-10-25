using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.Models
{
    public interface IActorRepository
    {
        IEnumerable<Actors> Actors { get; }
    }
}
