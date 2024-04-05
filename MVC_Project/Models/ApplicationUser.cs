using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Address {  get; set; }
        [ForeignKey("Customer")]
        public int CustomerID; 
        public Customer? Customer { get; set; }
    }
}
