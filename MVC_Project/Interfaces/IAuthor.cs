using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{
    public interface IAuthor
    {
        List<Author> GetAllAuthors();
        Author GetAuthorById(int id);
        void InsertAuthor(Author author);
        void UpdateAuthor(int id);
        void DeleteAuthor(int id);
        List<Book> GetAuthorBooks(string name);
        void Save();

        List<Author> GetAuthorsByName(string name);
	}
}
