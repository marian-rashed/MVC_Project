using MVC_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int QuantityAvailable { get; set; }

        [ForeignKey("Category")]
        public int? CategoryID { get; set; }
        public Category? Category { get; set; }

        public ICollection<Review> Reviews { get; set;}

       public bool? isOutOfStock { get; set; }
       public bool? isDeleted { get; set; }
    }
}
