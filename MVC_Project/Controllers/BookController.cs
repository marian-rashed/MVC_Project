using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Abstractions;
using MVC_Project.Interfaces;

namespace MVC_Project.Controllers
{
    public class BookController : Controller
    {
        IBook book;
        IAuthor author;
		private const int PageSize = 8;

		public BookController(IBook book,IAuthor author)
        {
            this.book = book;
            this.author = author;
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

        public IActionResult details(int id)
        {
            Book boo = book.GetBookById(id);
            boo.Author = author.GetAuthorById(boo.AuthorId);
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

