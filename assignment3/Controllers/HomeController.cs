using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using assignment3.Models;

namespace assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        //include the db context
        private MovieContext context;

        //include the db repository
        private IMovieRepository repository;

        public HomeController(ILogger<HomeController> logger, MovieContext ctx, IMovieRepository repo)
        {
            _logger = logger;
            context = ctx;
            repository = repo;
        }

        //index view, is called when user navigates to the root directory
        public IActionResult Index()
        {
            return View();
        }

        //get action to display the add film view
        [HttpGet]
        public IActionResult AddFilm()
        {
            return View();
        }

        //post action to submit the new film, only if the form is valid
        //if not valid it returns the view with the validation summary 
        [HttpPost]
        public IActionResult AddFilm(Films model)
        {
            if (ModelState.IsValid)
            {
                context.films.Add(model);
                context.SaveChanges();
                return Redirect("/Home/ViewFilms");
            }
            return View();
        }

        //display films view, just passes all records and displays them
        public IActionResult ViewFilms()
        {
            return View(context.films);
        }

        //method to delete a record, the record id is passed in
        //do not need to specify get/post becuase there is only one and it is post
        public IActionResult DeleteFilm(int id)
        {
            Films dbEntry = context.films
                .FirstOrDefault(f => f.id == id);
            if (dbEntry != null)
            {
                context.films.Remove(dbEntry);
                context.SaveChanges();
                TempData["message"] = $"{dbEntry.title} was deleted";
            }
            return Redirect("/Home/ViewFilms");
        }

        //display the edit film view, recieves the id of the record to be edited
        //passes that record into the view to be displayed in the form
        [HttpGet]
        public ViewResult EditFilm(int id) => View(context.films.FirstOrDefault(f => f.id == id));

        //is called when the save button on the editfilm view is pressed, calls the
        //savefilm method which updates only that record
        [HttpPost]
        public IActionResult EditFilm(Films film)
        {
            if (ModelState.IsValid)
            {
                repository.SaveFilm(film);
                TempData["message"] = $"{film.title} has been saved";
                return Redirect("/Home/ViewFilms");
            }
            return Redirect("/Home/ViewFilms");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
