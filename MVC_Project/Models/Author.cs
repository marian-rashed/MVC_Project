using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [MaxLength(25, ErrorMessage = "Name must be between 10 to 25 letter"), MinLength(10),]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Name must be Letters only")]
        public string AuthorName { get; set; }

        [MaxLength(100), MinLength(50)]
        public string Biography { get; set; }

        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Country must be Letters only")]
        public string Country { get; set; }

        public string ImageUrl { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
