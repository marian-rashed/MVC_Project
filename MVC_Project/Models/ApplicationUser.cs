using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Project.Models
{
    public class ApplicationUser : IdentityUser
    {

        //[Required(ErrorMessage = "Username is required.")]
        //[StringLength(50, MinimumLength = 4, ErrorMessage = "The {0} must be at least {2} characters long.")]
        //public string UserName { get; set; }
        public string Address { get; set; }
        [ForeignKey("Customer")]
        public String? CustomerID;
        public Customer? Customer { get; set; }
    }
}
