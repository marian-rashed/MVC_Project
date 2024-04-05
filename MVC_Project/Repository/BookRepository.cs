using Microsoft.EntityFrameworkCore;
using MVC_Project.Interfaces;

namespace MVC_Project.Repository
{
    public class BookRepository : IBook
    {
        BookStoreContext bookStoreContext;
        public BookRepository(BookStoreContext _bookStoreContext)
        {
            bookStoreContext = _bookStoreContext;
        }


        public List<Book> GetAllBooks()
        {
            List<Book> books = bookStoreContext.Books.Include(b => b.Author).ToList();
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = bookStoreContext.Books.Include(b => b.Author).FirstOrDefault(b => b.BookId == id);
            return book;
        }
        public void InsertBook(Book book)
        {
            bookStoreContext.Books.Add(book);
        }
        public void UpdateBook(int id)
        {
            Book book = bookStoreContext.Books.Include(b => b.Author).FirstOrDefault(b => b.BookId == id);
            bookStoreContext.Books.Update(book);
        }
        public void DeleteBook(int id)
        {
            Book book = bookStoreContext.Books.FirstOrDefault(b => b.BookId == id);
            bookStoreContext.Books.Remove(book);
        }
        public Author GetBookAuthor(string name)
        {
            Author author = bookStoreContext.Authors.FirstOrDefault(a => a.AuthorName == name);
            return author;
        }
        public void Save()
        {
            bookStoreContext.SaveChanges();
        }
        public List<Book> GetBooksByName(string name)
        {
            var books = bookStoreContext.Books.Where(b => b.Title.Contains(name)).ToList();
            return books;
        }

    }
}
