using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"

            };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
                
            };

            //ViewData["Movie"] = movie;

            //ViewBag.Movie = movie;

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);

            //return Content("hello buddy");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Edit", "Movies", new {id = 39687, person = "me!", boo = true});
        }

        [HttpGet]
        public JsonResult Parse()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"

            };
            return Json(movie, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(string.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));
        }

        [Route("movies/release/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int? year, int month)
        {


            return Content(year + "/" + month);
        }
    }
}