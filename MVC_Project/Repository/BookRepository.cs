using Microsoft.EntityFrameworkCore;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using NuGet.Common;
using System.Net;

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
            List<Book> books = bookStoreContext.Books
                .Include(b => b.Author)
                .Where(b => b.isDeleted != true)
                .OrderBy(b=>b.Title)
                .ToList();
            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = bookStoreContext.Books.Include(b => b.Author).FirstOrDefault(b => b.BookId == id);
            book.Reviews=bookStoreContext.Reviews.Where(r => r.BookID == id).ToList();
            foreach(Review rev in book.Reviews)
            {
                rev.User = new ApplicationUser();
                rev.User.UserName = bookStoreContext.Users.Where(u=>u.Id==rev.UserId).Select(r => r.UserName).FirstOrDefault();
				
			}
			return book;
        }
        public void InsertBook(Book book)
        {
            bookStoreContext.Books.Add(book);
        }
        public void UpdateBook(Book book)
        {
            Book bookDB = bookStoreContext.Books.Include(b => b.Author).FirstOrDefault(b => b.BookId == book.BookId);
            bookDB.QuantityAvailable=book.QuantityAvailable;

            bookStoreContext.Books.Update(bookDB);
            
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
		public void EditBook(Book book)
		{
			// Retrieve the existing book from the database
			var existingBook = bookStoreContext.Books.FirstOrDefault(b => b.BookId == book.BookId);

			if (existingBook != null)
			{
				// Update the existing book properties with the new values
				existingBook.Title = book.Title;
				existingBook.Author = book.Author;
				//existingBook.ISBN = book.ISBN;

				// You can update other properties as well

				// Save changes to the database
				//bookStoreContext.SaveChanges();
			}
			else
			{
				// Handle case where the book to be updated is not found
				throw new ArgumentException("Book not found");
			}
		}

        //random books
        public List<Book> GetRandomBooks(int count)
        {
            Random random = new Random();
            List<int> validIndices = bookStoreContext.Books.Select(b => b.BookId).ToList();

            // Ensure count does not exceed totalBooks
            count = Math.Min(count, validIndices.Count);

            // Shuffle the list of valid indices
            for (int i = validIndices.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                int temp = validIndices[i];
                validIndices[i] = validIndices[j];
                validIndices[j] = temp;
            }

            // Take the first 'count' indices
            List<int> selectedIndices = validIndices.Take(count).ToList();

            // Retrieve books corresponding to the selected indices
            var randomBooks = bookStoreContext.Books
                .Where(b => selectedIndices.Contains(b.BookId))
                .Include(b => b.Author)
                .ToList();

            return randomBooks;
        }



    }
}
