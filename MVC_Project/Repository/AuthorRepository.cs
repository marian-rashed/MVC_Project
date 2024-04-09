using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;

namespace MVC_Project.Repository
{
    public class AuthorRepository:IAuthor
    {
        BookStoreContext bookStoreContext;
        public AuthorRepository(BookStoreContext _bookStoreContext)
        {
            bookStoreContext = _bookStoreContext;
        }
        public void DeleteAuthor(int id)
        {
            Author author = bookStoreContext.Authors.FirstOrDefault(a => a.AuthorId == id);
            bookStoreContext.Authors.Remove(author);
        }

        public List<Author> GetAllAuthors()
        {
            List<Author> authors = bookStoreContext.Authors.ToList();
            return authors;
        }

        public List<Book> GetAuthorBooks(string name)
        {
            // bookStoreContext.Authors.Where(a => a.AuthorName == name).Select(a => a.Books).ToList();

            Author author = bookStoreContext.Authors.FirstOrDefault(a => a.AuthorName == name);
            return author.Books.ToList();
        }

        public Author GetAuthorById(int id)
        {
            Author author = bookStoreContext.Authors.FirstOrDefault(a => a.AuthorId == id);
            return author;
        }

        public void InsertAuthor(Author author)
        {
            bookStoreContext.Authors.Add(author);
        }

        public void Save()
        {
            bookStoreContext.SaveChanges();
        }

        public void UpdateAuthor(int id)
        {
            Author author = bookStoreContext.Authors.FirstOrDefault(a => a.AuthorId == id);
            Author auth = new Author()
            {
                AuthorName=author.AuthorName,
                AuthorId=author.AuthorId,
                Biography=author.Biography,
                BirthDate=author.BirthDate,
                Country=author.Country,
                ImageUrl=author.ImageUrl,
                Books=author.Books,
            };
            //return auth;
            bookStoreContext.SaveChanges();
        }

        public Author GetAuthorByName(string name) 
        { 
            Author author=bookStoreContext.Authors.FirstOrDefault(a=>a.AuthorName == name);
            return author;
        }

        public List<Author> GetAuthorsByName(string name)
        {
            var authors = bookStoreContext.Authors.Where(a => a.AuthorName.Contains(name)).ToList();
            return authors;
        }
        
    }
}
