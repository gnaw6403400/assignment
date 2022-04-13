using Microsoft.AspNetCore.Mvc;
using MovieStoreApp.WebMVC.Models;
using MovieStoreApp.WebMVC.Repository;
namespace MovieStoreApp.WebMVC.Controllers
{
    public class MovieController : Controller
    {
        MovieRepository movieRepository;
        public MovieController()
        {
            movieRepository = new MovieRepository();
        }
        public IActionResult Index()
        {
            ViewBag.Title = "All Movies";

            IEnumerable<MovieModel> lstMovies = movieRepository.GetAll(); 

            return View(lstMovies);
        }

        public IActionResult Detail(int movieId, string moviename)
        {
            MovieModel movieModel= movieRepository.GetById(movieId);
            return View(movieModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieModel movieModel)
        {
            //call the repository insert method to save the movie in database
            if (movieModel.Title != null)
            {
                return RedirectToAction("Index");
            }
            return View(movieModel);
        }
    }
}
