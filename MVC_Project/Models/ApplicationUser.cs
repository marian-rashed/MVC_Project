using Microsoft.AspNetCore.Identity;

namespace MVC_Project.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string Address {  get; set; }
    }
}
