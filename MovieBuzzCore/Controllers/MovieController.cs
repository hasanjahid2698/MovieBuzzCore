using Microsoft.AspNetCore.Mvc;
using MovieBuzz.Application.Common.Interfaces;
using MovieBuzz.Application.Common.Services.Implementation;
using MovieBuzz.Application.Common.Services.Interfaces;
using MovieBuzz.Domain.Entities;

namespace MovieBuzz.Web.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index()
        {
            var movies = _movieService.GetAllMovies();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Movie obj)
        {
            if (ModelState.IsValid)
            {

                _movieService.CreateMovie(obj);
                TempData["success"] = "The movie has been created successfully.";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Update(int movieId)
        {
            Movie? obj = _movieService.GetMovieById(movieId);
            if (obj == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Update(Movie obj)
        {
            if (ModelState.IsValid && obj.Id > 0)
            {
                _movieService.UpdateMovie(obj);
                TempData["success"] = "The movie has been updated successfully.";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Delete(int movieId)
        {
            Movie? obj = _movieService.GetMovieById(movieId);
            if (obj is null)
            {
                TempData["error"] = "An error occured.";
                return RedirectToAction("Error", "Home");
            }
            return View(obj);
        }


        [HttpPost]
        public IActionResult Delete(Movie obj)
        {
            bool deleted = _movieService.DeleteMovie(obj.Id);
            if (deleted)
            {
                TempData["success"] = "The movie has been deleted successfully.";
                return RedirectToAction(nameof(Index));
            }
            else
            {
                TempData["error"] = "Failed to delete the movie.";
            }
            return View();
        }

    }
}
