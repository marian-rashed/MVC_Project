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
            bookStoreContext.Authors.Update(author);
        }
    }
}
