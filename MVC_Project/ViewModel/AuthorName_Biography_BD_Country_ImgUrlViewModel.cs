using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModel
{
    public class AuthorName_Biography_BD_Country_ImgUrlViewModel
    {
        [MaxLength(25, ErrorMessage = "AuthorName must be between 10 to 25 letter"), MinLength(10)]
        [RegularExpression(@"^[A-Za-z]{10,25}$", ErrorMessage = "Author name must be between 10 and 25 letters and contain only alphabetic characters.")]
        public string AuthorName { get; set; }

        [MaxLength(1000, ErrorMessage = "Biography must be between 50 to 1000 letter"), MinLength(50)]
        [RegularExpression(@"^[A-Za-z]{50,1000}$", ErrorMessage = "Biography must be between 50 and 1000 letters and contain only alphabetic characters.")]
        public string Biography { get; set; }

        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[A-Za-z ]{3,20}$", ErrorMessage = "Country must contain only letters and be between 3 and 20 characters long.")]
        public string Country { get; set; }

        public string? ImageUrl { get; set; }
    }
}
