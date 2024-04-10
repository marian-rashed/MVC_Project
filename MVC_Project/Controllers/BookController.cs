using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Abstractions;
using MVC_Project.Interfaces;

namespace MVC_Project.Controllers
{
    public class BookController : Controller
    {
        IBook book;
		private const int PageSize = 10;

		public BookController(IBook book)
        {
            this.book = book;
        }
        public IActionResult Index(int page = 1)
        {
            int totalBooks = book.GetAllBooks().Count();
            List<Book> BookList = book.GetAllBooks()
                .Skip((page - 1) * PageSize) // Correct calculation for skipping items
                .Take(PageSize)
                .ToList();

            ViewBag.TotalPages = (int)System.Math.Ceiling(totalBooks / (double)PageSize);
            ViewBag.CurrentPage = page;
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
        public async Task< IActionResult> SaveBook(Book boo, IFormFile ImageUrl)
        {
            if (boo.Title!=null && boo.AuthorId!=null && boo.Price!=null && ImageUrl!=null && boo.QuantityAvailable!=null)
            {
                if (ImageUrl != null && ImageUrl.Length > 0)
                {
                    var fileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(ImageUrl.FileName);
                    var filePath = Path.Combine("wwwroot/images", fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await ImageUrl.CopyToAsync(stream);
                    }

                    boo.ImageUrl = "/images/" + fileName;
                    book.InsertBook(boo);
                    book.Save();
                    return RedirectToAction("Index");
                }
              
            }

            return View("AddNewBook", boo);

        }
        public IActionResult GetBooksByName(string name)
        {
            var books = book.GetBooksByName(name);
            return View("GetBooksByName", books);
        }

        //edit book
        //delete book
    }
}

