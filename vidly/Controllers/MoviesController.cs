﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "customer 1"},
                new Customer { Name = "customer 2"}
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

        public  ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
           
            if (String.IsNullOrWhiteSpace(sortBy))
           
                sortBy = "name";

            return Content(String.Format("pageIndex={0}&sortBy{1}", pageIndex, sortBy));

        }
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]

        public  ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}