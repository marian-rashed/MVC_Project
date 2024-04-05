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

        //by name
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

        //edit book
        //delete book
    }
}

