using MVC_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project
{
    public class Book
    {

        [Key]
        public int BookId { get; set; }

        [MaxLength(500, ErrorMessage = "Book Title must be between 150 to 500 letter"), MinLength(50)]
        [RegularExpression(@"^[A-Za-z]{50,500}$", ErrorMessage = "Book title must be between 50 and 500 letters and contain only alphabetic characters.")]
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        
        [RegularExpression("^\\d{2,5}$",ErrorMessage = "Price must consist of digits and be between 2 and 5 digits long.")]
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        [RegularExpression("^\\d{1,3}$", ErrorMessage = "Quantity must consist of digits and be between 1 and 3 digits long.")]
        public int QuantityAvailable { get; set; }

        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<Review> Reviews { get; set;}

       public bool? isOutOfStock { get; set; }
       public bool? isDeleted { get; set; }
    }
}
