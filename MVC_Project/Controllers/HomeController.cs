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
		IBook book;
		public HomeController(IBook book, IAuthor _author, ILogger<HomeController> logger)
		{
			author = _author;
			_logger = logger;
			this.book = book;
		}

		public ActionResult SearchByAuthor(string query)
		{
			// Here you would perform your search logic
			// For simplicity, let's assume you already have a method to fetch authors based on the search query
			List<Author> authors = YourSearchLogicMethod(query);

			// Pass the list of authors to the view
			return View(authors);
		}
		public ActionResult SearchByBook(string query)
		{
			// Here you would perform your search logic
			// For simplicity, let's assume you already have a method to fetch authors based on the search query
			List<Book> books = YourSearchLogicMethod2(query);

			// Pass the list of authors to the view
			return View(books);
		}

		// This is a placeholder for your search logic
		private List<Author> YourSearchLogicMethod(string query)
		{
			List<Author> dummyAuthors = author.GetAuthorsByName(query);
			return dummyAuthors;
		}
		private List<Book> YourSearchLogicMethod2(string query)
		{
			List<Book> dummybooks = book.GetBooksByName(query);
			return dummybooks;
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
