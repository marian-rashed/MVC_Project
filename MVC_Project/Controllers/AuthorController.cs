using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.Repository;

namespace MVC_Project.Controllers
{
    public class AuthorController :Controller
    {
        IAuthor author;
        public AuthorController(IAuthor _author)
        {
            author = _author;
        }
        public IActionResult Index()
        {
            List<Author> authorList = author.GetAllAuthors();
            return View("Index", authorList);
        }
        public IActionResult GetAuthorById(int id)
        {
            Author author1=author.GetAuthorById(id);
            return View("GetAuthorById", author1);
        }
    }
}
