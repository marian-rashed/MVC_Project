using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.IdentityModel.Abstractions;

using MVC_Project.Interfaces;

namespace MVC_Project.Controllers
{
    public class BookController : Controller
    {
        IBook book;
        IAuthor author;
        private const int PageSize = 8;

        public BookController(IBook book, IAuthor author)
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
            boo.Author = author.GetAuthorById((int)boo.AuthorId);
            return View("GetBookById", boo);
        }

        [HttpGet]
        public IActionResult AddNewBook()
        {
            var authors = author.GetAllAuthors();

            if (authors != null)
            {
                SelectList authorList = new SelectList(authors, "AuthorId", "AuthorName");
                ViewBag.Authors = authorList;
            }
            else
            {
                ViewBag.Authors = new SelectList(new List<Author>(), "AuthorId", "AuthorName");
            }

            return View("AddNewBook");
        }

        [HttpPost]
        public async Task<IActionResult> SaveBook(Book boo, IFormFile ImageUrl)
        {


            if (boo.Title!=null ||boo.Price!=0||boo.AuthorId!=0||boo.QuantityAvailable!=0)

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
        public ActionResult SearchByBook(string query)
        {
            // Here you would perform your search logic
            // For simplicity, let's assume you already have a method to fetch authors based on the search query
            List<Book> books = YourSearchLogicMethod2(query);

            // Pass the list of authors to the view
            return View("GetBooksByName", books);
        }

        // This is a placeholder for your search logic

        private List<Book> YourSearchLogicMethod2(string query)
        {
            List<Book> dummybooks = book.GetBooksByName(query);
            return dummybooks;
        }
        public IActionResult GetBooksByName(string name)
        {
            var books = book.GetBooksByName(name);

            return View("GetBooksByName", books);
        }

        public IActionResult Delete(int id)
        {
            Book bookToDelete = book.GetBookById(id);
            bookToDelete.isDeleted = true;
            book.Save();
            return RedirectToAction("Index");
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
    }
}

