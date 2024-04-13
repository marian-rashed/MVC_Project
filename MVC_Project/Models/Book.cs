using MVC_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(500, ErrorMessage = "Book Title must be between 150 to 500 letter"), MinLength(150)]
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        
        [RegularExpression("^\\d{2,5}$",ErrorMessage ="Price Must be consist of digit(from 2 digit to 5)")]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        [RegularExpression("^\\d{1,3}$", ErrorMessage = "Quantity Must be consist of digit(from 1 digit to 3)")]
        public int QuantityAvailable { get; set; }

        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<Review> Reviews { get; set;}

       public bool? isOutOfStock { get; set; }
       public bool? isDeleted { get; set; }
    }
}
