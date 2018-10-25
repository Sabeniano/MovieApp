using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieAppCore.Models;
using MovieAppCore.ViewModels;

namespace MovieAppCore.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMovieRepository _movieRepository;
        private readonly IGenreRepository _genreRepository;

        public MoviesController(IMovieRepository movieRepository, IGenreRepository genreRepository)
        {
            _movieRepository = movieRepository;
            _genreRepository = genreRepository;
        }

        public ViewResult List()
        {
            MoviesListViewModel moviesListViewModel = new MoviesListViewModel();
            moviesListViewModel.Movies = _movieRepository.Movies;
            moviesListViewModel.CurrentGenre = "Action Movies";
            return View(moviesListViewModel);
        }
    }
}