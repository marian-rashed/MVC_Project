using MVC_Project.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_Project
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }
        public Customer()
        {
                CustomerId = Guid.NewGuid().ToString();
        }
        public string? ImgURL { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Order>? Orders { get; set; }
        public ICollection<Review>? Reviews { get; set; }
    }
}
