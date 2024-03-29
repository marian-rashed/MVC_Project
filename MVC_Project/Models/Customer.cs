using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        public string Username { get; set; }

        public string Password { get; set; } 

        public string Email { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
