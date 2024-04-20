using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.Repository;

namespace MVC_Project.Controllers
{
    public class CartController : Controller
    {

        IBook book;
        public CartController(IBook _book)
        {
            book= _book;
        }
        public IActionResult SelectedBooks([FromBody] int[] selectedBooksID)
        {
            // Store selectedBooksID in TempData to pass it to the view
            TempData["SelectedBooksID"] = selectedBooksID;
            // Return a JSON response indicating success
            return Json(new { success = true });
        }

        public IActionResult DisplayProduct()
        {
            // Retrieve selectedBooksID from TempData and pass it to the view
            List<Book> books = new List<Book>();
            var selectedBooksID = TempData["SelectedBooksID"] as int[];
            if (selectedBooksID != null)
            {
                foreach (var bookId in selectedBooksID)
                {
                    // Assuming you have a method to retrieve a book by its ID from a repository
                    Book Onebook = book.GetBookById(bookId);
                    if (Onebook != null)
                    {
                        books.Add(Onebook);
                    }
                }
            }

            return View(books); // Return an empty array if null
        }




    }
}
