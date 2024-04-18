using MVC_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project
{
    public class Book
    {

        [Key]
        public int BookId { get; set; }

        [MaxLength(100), MinLength(2)]
        [RegularExpression(@"^[A-Za-z]{2,100}$", ErrorMessage = "Book title must be between 2 and 100 letters and contain only alphabetic characters.")]
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }

        
        [RegularExpression("^\\d{1,10}$",ErrorMessage = "Price must consist of digits and be between 1 and 10 digits long.")]
        public decimal Price { get; set; }

        [RegularExpression(@"^.*\.(jpg|jpeg|jfif|pjpeg|pjp|png|svg|webp|JPG|JPEG|JFIF|PJPEG|PJP|PNG|SVG|WEBP)$", ErrorMessage = "Image URL must have a valid image extension (.jpg, .jpeg, .jfif, .pjpeg, .pjp, .png, .svg, .webp,.JPG,.JPEG,.JFIF,.PJPEG,.PJP,.PNG,.SVG,.WEBP)")]
        public string ImageUrl { get; set; }

        [RegularExpression("^\\d{1,10}$", ErrorMessage = "Quantity must consist of digits and be between 1 and 10 digits long.")]
        public int QuantityAvailable { get; set; }

        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<Review>? Reviews { get; set;}

       public bool? isOutOfStock { get; set; }
       public bool? isDeleted { get; set; }
    }
}
