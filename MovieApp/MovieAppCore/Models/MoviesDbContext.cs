using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using MovieApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAppCore.Models
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SKAB2-PC-09;Database=MoviesDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieActors>().HasKey(sc => new { sc.MovieId, sc.ActorId });
            modelBuilder.Entity<MovieGenres>().HasKey(sc => new { sc.MovieId, sc.GenreId });
            modelBuilder.Entity<Movies>().HasOne<Directors>(s => s.Directors).WithMany(g => g.Movies).HasForeignKey(s => s.DirectorId);
        }
        public DbSet<Movies> Movies { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Directors> Directors { get; set; }
        public DbSet<Actors> Actors { get; set; }
        public DbSet<MovieActors> MovieActor { get; set; }
        public DbSet<MovieGenres> MovieGenre { get; set; }
    }
}
