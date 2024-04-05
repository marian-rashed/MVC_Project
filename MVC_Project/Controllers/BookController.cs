using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;

namespace MVC_Project.Controllers
{
    public class BookController : Controller
    {
        IBook book;
        public BookController(IBook book)
        {
            this.book = book;
        }
        public IActionResult Index()
        {
            List<Book> BookList = book.GetAllBooks();
            return View("index", BookList);

        }

       
        public IActionResult GetBookById(int id)
        {
            Book boo = book.GetBookById(id);
            return View("GetBookById", boo);
        }

        [HttpGet]
        public IActionResult AddNewBook(Book book)
        {
            return View("AddNewBook");
        }
        [HttpPost]
        public IActionResult SaveBook(Book boo)
        {
            if (ModelState.IsValid == false)
            {
                return View("AddNewBook", boo);
            }
            book.InsertBook(boo);
            book.Save();

            return RedirectToAction("Index");
        }
        public IActionResult GetBooksByName(string name)
        {
            var books = book.GetBooksByName(name);
            return View("GetBooksByName", books);
        }

		[HttpGet]
		public IActionResult EditBook(int id)
		{
			// Retrieve the book by ID
			var book1 = book.GetBookById(id);

			if (book1 == null)
			{
				// Handle case where book with given ID is not found
				return NotFound();
			}

			return View("EditBook", book1);
		}

		[HttpPost]
		public IActionResult SaveEditedBook(Book editedBook)
		{
			if (ModelState.IsValid)
			{
				book.EditBook(editedBook);
                return RedirectToAction("Index");
			}
			else
			{
				// If the model state is not valid, return to the edit view with the model
				return View("EditBook", editedBook);
			}
		}

		//edit book
		//delete book
	}
}

