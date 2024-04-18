using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModel
{
    public class AssignRoleViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }

        public string role { get; set; }


    }
}
