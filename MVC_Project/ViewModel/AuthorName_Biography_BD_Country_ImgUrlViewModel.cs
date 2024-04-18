using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MVC_Project.ViewModel
{
    public class AuthorName_Biography_BD_Country_ImgUrlViewModel
    {
        [MaxLength(50), MinLength(1)]
        [RegularExpression(@"^[A-Za-z]{1,50}$", ErrorMessage = "Author name must be between 1 and 50 letters and contain only alphabetic characters.")]
        public string AuthorName { get; set; }

        [MaxLength(1000), MinLength(1)]
        [RegularExpression(@"^[A-Za-z0-9]{1,1000}$", ErrorMessage = "Biography must contain only letters and numbers, and be between 1 and 1000 characters long.")]
        public string Biography { get; set; }

        public DateTime BirthDate { get; set; }

        [RegularExpression(@"^[A-Za-z ]{4,56}$", ErrorMessage = "Country must contain only letters and be between 4 and 56 characters long.")]
        public string Country { get; set; }

        [RegularExpression(@"^.*\.(jpg|jpeg|jfif|pjpeg|pjp|png|svg|webp|JPG|JPEG|JFIF|PJPEG|PJP|PNG|SVG|WEBP)$", ErrorMessage = "Image URL must have a valid image extension (.jpg, .jpeg, .jfif, .pjpeg, .pjp, .png, .svg, .webp,.JPG,.JPEG,.JFIF,.PJPEG,.PJP,.PNG,.SVG,.WEBP)")]
        public string? ImageUrl { get; set; }



    }
}
