using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using System.Diagnostics;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IAuthor author;
        public HomeController(IAuthor _author, ILogger<HomeController> logger)
        {
            author = _author;
            _logger = logger;
        }

        public ActionResult Search(string query)
        {
            // Here you would perform your search logic
            // For simplicity, let's assume you already have a method to fetch authors based on the search query
            List<Author> authors = YourSearchLogicMethod(query);

            // Pass the list of authors to the view
            return View(authors);
        }

        // This is a placeholder for your search logic
        private List<Author> YourSearchLogicMethod(string query)
        {
            // Implement your search logic here
            // Return a list of authors based on the search query
            // This method could interact with your database or any other data source
            // For demonstration purposes, let's return a dummy list
            List<Author> dummyAuthors = author.GetAuthorsByName(query);
            return dummyAuthors;
        }



        public IActionResult Index()
        {
            return View();
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
