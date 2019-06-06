using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Shrek" };
            //return View(movie);
            //return Content("hello world");
            //return HttpNotFound();
            return RedirectToAction("index", "home", new { page = 1, sortBy = "name" });


        }
    }
}