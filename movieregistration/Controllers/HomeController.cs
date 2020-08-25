using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using movieregistration.Models;

namespace movieregistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration()
        {
            return View();
        }

        List<Movie> movieList = new List<Movie>();
        public IActionResult Display(Movie m)
        {
           
                string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";
                if (movieListJSON != "EmptySession")
                {
                    movieList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
                }
                movieList.Add(m);
                movieListJSON = JsonSerializer.Serialize(movieList);
                HttpContext.Session.SetString("MovieListSession", movieListJSON);
                return View("Display", movieList);
        }
        public IActionResult EndSession()
        {
            HttpContext.Session.Remove("MovieListSession");
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
