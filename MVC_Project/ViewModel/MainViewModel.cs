namespace MVC_Project.ViewModel
{
    public class MainViewModel
    {
       
       public List<Book> FeaturedBooksModel { get; set; }
        public List<Book> PopularBooks { get; set; }
        public List<Book> SpecialOffer {  get; set; }
        public List<Book> Slider { get; set; }
        public Book BestSelling { get; set; }
        public MainViewModel()
        {
            FeaturedBooksModel = new List<Book>();
            PopularBooks=new List<Book>();
            SpecialOffer = new List<Book>();
            Slider = new List<Book>();
            BestSelling = new Book();
        }
    }
}
