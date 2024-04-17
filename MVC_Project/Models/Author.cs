using System.ComponentModel.DataAnnotations;

namespace MVC_Project
{
	public class Author
	{
		[Key]
		public int AuthorId { get; set; }


        public string AuthorName { get; set; }

        
        public string Biography { get; set; }

		public DateTime BirthDate { get; set; }


        
       public string Country { get; set; }

		public string ImageUrl { get; set; }

		public bool? isDeleted { get; set; }

		public ICollection<Book> Books { get; set; }
	}
}
