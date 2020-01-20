using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieLibrary.Models;
using MovieLibrary.ViewModels;

namespace MovieLibrary.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Inception" };
            var movie1 = new Movie() { Name = "Gattaca" };
            return View();
        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Someday" };

            var customers = new List<Customer>
            {
                new Customer{Name = "Michael Smith"},
                new Customer{Name = "Mary Williamps"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}