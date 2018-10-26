using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAppCore.Models;
using MovieAppCore.ViewModels;

namespace MovieAppCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        //private readonly IMovieRepository _movieRepository;
        //private readonly IGenreRepository _genreRepository;

        //public MoviesController(IMovieRepository movieRepository, IGenreRepository genreRepository)
        //{
        //    _movieRepository = movieRepository;
        //    _genreRepository = genreRepository;
        //}

        private readonly MoviesDbContext _context;
        
        public MoviesController(MoviesDbContext context)
        {
            _context = context;
            if (!context.Movies.Any())
            {
                context.AddRange
                (
                    new Movies { Title = "Movie", Description = "Description", RunTime = TimeSpan.FromMinutes(0), ReleaseDate = DateTime.Today, ImageUrl = "https://m.media-amazon.com/images/M/MV5BNGNiNWQ5M2MtNGI0OC00MDA2LWI5NzEtMmZiYjVjMDEyOWYzXkEyXkFqcGdeQXVyMjM4NTM5NDY@._V1_SY1000_CR0,0,674,1000_AL_.jpg" }
                );
            }
            context.SaveChanges();
        }

        [HttpGet]
        public ActionResult<List<Movies>> GetAll()
        {
            return _context.Movies.ToList();

        }
        
        [HttpGet("{id}", Name = "GetMovies")]
        public ActionResult<Movies> GetById(int id)
        {
            var item = _context.Movies.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Create(Movies item)
        {
            _context.Movies.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetMovies", new { id = item.MovieId }, item);
        }

        [HttpPatch("{id}")]
        public IActionResult Update(int id, Movies item)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            movie.Title = item.Title;
            movie.Description = item.Description;
            movie.ReleaseDate = item.ReleaseDate;
            movie.RunTime = item.RunTime;
            movie.ImageUrl = item.ImageUrl;

            _context.Movies.Update(movie);
            _context.SaveChanges();
            return Ok(movie);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return NoContent();
        }

        //   public ViewResult List()
        //   {
        //        MoviesListViewModel moviesListViewModel = new MoviesListViewModel();
        //        moviesListViewModel.Movies = _movieRepository.Movies;
        //        moviesListViewModel.CurrentGenre = "Action Movies";
        //        return View(moviesListViewModel);
        //   }
    }
}