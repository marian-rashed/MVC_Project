using System.ComponentModel.DataAnnotations;

namespace MVC_Project.ViewModel
{
    public class AuthorName_Biography_BD_Country_ImgUrlViewModel
    {
        [MaxLength(25, ErrorMessage = "AuthorName must be between 10 to 25 letter"), MinLength(10),]
        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Name must be Letters only")]
        public string AuthorName { get; set; }

        [MaxLength(1000, ErrorMessage = "Biography must be between 50 to 1000 letter"), MinLength(50)]
        public string Biography { get; set; }

        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[A-Za-z ]+$", ErrorMessage = "Country must be Letters only")]
        public string Country { get; set; }

        public string? ImageUrl { get; set; }
    }
}
