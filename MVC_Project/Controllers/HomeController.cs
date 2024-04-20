using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using System.Diagnostics;
using MVC_Project.ViewModel;

namespace MVC_Project.Controllers
{
    public class HomeController : Controller
    {
		IBook book;
		IAuthor author;
		private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IBook book, IAuthor author)
        {

            _logger = logger;
			this.book = book;
			this.author = author;
		}
		
		//private const int PageSize = 8;


		public IActionResult Index()
        {
            var model = new MainViewModel
            {
                FeaturedBooksModel = book.GetRandomBooks(4),
                BestSelling = book.GetRandomBooks(1).FirstOrDefault(),
                PopularBooks = book.GetRandomBooks(8),
                SpecialOffer =book.GetRandomBooks(5),
                Slider=new List<Book>() { book.GetBookById(2),book.GetBookById(34) }
            };
            return View("Index",model);
        }
        public IActionResult Contact()
        {
            return View("Contact");
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
