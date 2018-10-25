using Microsoft.EntityFrameworkCore;
using MovieApp.Entities;
using System;
using System.Diagnostics;
using System.Linq;

namespace MovieApp
{
    public class MoviesDbContext : DbContext
    {
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
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new MoviesDbContext())
            {
                //context.Genres.Add(new Genres { Genre = "Comedy" });
                //context.Genres.Add(new Genres { Genre = "Action" });
                //context.Genres.Add(new Genres { Genre = "Romance" });
                //context.Genres.Add(new Genres { Genre = "Horror" });
                //context.Genres.Add(new Genres { Genre = "Drama" });
                //context.Genres.Add(new Genres { Genre = "Fantasy" });
                //context.Genres.Add(new Genres { Genre = "Animation" });
                //context.Genres.Add(new Genres { Genre = "Sci-fi" });

                //context.SaveChanges();
            }
        }
    }
}
