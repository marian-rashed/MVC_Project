using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    public class Review
    { 
        public int Id { get; set; }
        [ForeignKey("Customer")]
        public string CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Book")]
        public int BookID { get; set; }
        public Book Book { get; set; }
        
        public string Text { get; set; }
        public int StarNum { get; set; }
    }
}