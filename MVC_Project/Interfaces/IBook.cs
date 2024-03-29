using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{
    public interface IBook
    {
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        void InsertBook(Book book);
        void UpdateBook(int id);
        void DeleteBook(int id);
        Author GetBookAuthor(string name);
        void Save();
    }
}
