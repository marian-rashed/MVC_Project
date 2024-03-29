using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project
{
    public class BookStoreContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public BookStoreContext() : base() { }

        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=BooK_Store;Integrated Security=True;Trust Server Certificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    AuthorName = "Sandra Cisneros",
                    Biography = "Sandra Cisneros is an American writer best known for her acclaimed first novel The House on Mango Street.",
                    BirthDate = DateTime.Parse("1954-12-20"),
                    Country = "United States",
                    ImageUrl = "1.png"
                },
               new Author
               {
                   AuthorId = 3,
                   AuthorName = "Sarah J. Maas",
                   Biography = "Sarah J. Maas is the #1 New York Times and internationally bestselling author of the Crescent City, A Court of Thorns and Roses, and the Throne of Glass series. Her books have sold more than twelve million copies and are published in thirty-seven languages. A New York native, Sarah lives in Philadelphia with her husband, son, and dog. To find out more, visit sarahjmaas.com or follow @therealsjmaas on Instagram.",
                   BirthDate = DateTime.Parse("1986 -03-05"),
                   Country = "United States",
                   ImageUrl = "/images/author/Sarah J. Maas.jpeg"
               },
               new Author
               {
                   AuthorId = 4,
                   AuthorName = "Leigh Bardugo",
                   Biography = "Leigh Bardugo is an American fantasy author. She is best known for her young adult Grishaverse novels, which include the Shadow and Bone trilogy and the Six of Crows and King of Scars duologies. She also received acclaim for her paranormal fantasy adult debut, Ninth House",
                   BirthDate = DateTime.Parse("1975 -04-06"),
                   Country = "United States",
                   ImageUrl = "/images/author/Leigh Bardugo.jpeg"
               }
               ,
               new Author
               {
                   AuthorId = 5,
                   AuthorName = "Cassandra Clare",
                   Biography = "Judith Lewis, better known by her pen name Cassandra Clare, is an American author of young adult fiction, best known for her bestselling series The Mortal Instruments.",
                   BirthDate = DateTime.Parse("1975 -04-06"),
                   Country = "United States",
                   ImageUrl = "/images/author/Cassandra Clare.jpeg"
               }, new Author
               {
                   AuthorId = 6,
                   AuthorName = "J.K. Rowling",
                   Biography = "J.K. Rowling is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series, which has won multiple awards and sold more than 500 million copies, becoming the best-selling book series in history.",
                   BirthDate = DateTime.Parse("1965-07-31"),
                   Country = "United Kingdom",
                   ImageUrl = "/images/author/jk_rowling.jpeg"
               }, new Author
               {
                   AuthorId = 7,
                   AuthorName = "Stephen King",
                   Biography = "Stephen King is an American author of horror, supernatural fiction, suspense, crime, science-fiction, and fantasy novels. His books have sold more than 350 million copies, and many have been adapted into films, television series, miniseries, and comic books.",
                   BirthDate = DateTime.Parse("1947-09-21"),
                   Country = "United States",
                   ImageUrl = "/images/author/stephen_king.jpeg"
               }, new Author
               {
                   AuthorId = 8,
                   AuthorName = "Haruki Murakami",
                   Biography = "Haruki Murakami is a Japanese writer. His books and stories have been bestsellers in Japan and internationally, with his work being translated into 50 languages and selling millions of copies outside his native country.",
                   BirthDate = DateTime.Parse("1949-01-12"),
                   Country = "Japan",
                   ImageUrl = "/images/author/haruki_murakami.jpeg"
               }, new Author
               {
                   AuthorId = 9,
                   AuthorName = "Margaret Atwood",
                   Biography = "Margaret Atwood is a Canadian poet, novelist, literary critic, essayist, inventor, teacher, and environmental activist. She has published over 17 books of poetry, 16 novels, 10 books of non-fiction, 8 collections of short fiction, 8 children's books, and 1 graphic novel.",
                   BirthDate = DateTime.Parse("1939-11-18"),
                   Country = "Canada",
                   ImageUrl = "/images/author/margaret_atwood.jpeg"
               }, new Author
               {
                   AuthorId = 10,
                   AuthorName = "George R.R. Martin",
                   Biography = "George R.R. Martin is an American novelist and short story writer, screenwriter, and television producer. He is best known for his series of epic fantasy novels, A Song of Ice and Fire, which was adapted into the HBO series Game of Thrones.",
                   BirthDate = DateTime.Parse("1948-09-20"),
                   Country = "United States",
                   ImageUrl = "/images/author/george_rr_martin.jpeg"
               }, new Author
               {
                   AuthorId = 11,
                   AuthorName = "Toni Morrison",
                   Biography = "Toni Morrison was an American novelist, essayist, editor, teacher, and professor emeritus at Princeton University. She won the Pulitzer Prize and the American Book Award in 1988 for Beloved.",
                   BirthDate = DateTime.Parse("1931-02-18"),
                   Country = "United States",
                   ImageUrl = "/images/author/toni_morrison.jpeg"
               }, new Author
               {
                   AuthorId = 12,
                   AuthorName = "Gabriel García Márquez",
                   Biography = "Gabriel García Márquez was a Colombian novelist, short-story writer, screenwriter, and journalist, known affectionately as Gabo throughout Latin America. He is considered one of the most significant authors of the 20th century.",
                   BirthDate = DateTime.Parse("1927-03-06"),
                   Country = "Colombia",
                   ImageUrl = "/images/author/gabriel_garcia_marquez.jpeg"
               }, new Author
               {
                   AuthorId = 13,
                   AuthorName = "Chimamanda Ngozi Adichie",
                   Biography = "Chimamanda Ngozi Adichie is a Nigerian writer whose works range from novels to short stories to nonfiction. She was described in The Times Literary Supplement as 'the most prominent' of a 'procession of critically acclaimed young anglophone authors [which] is succeeding in attracting a new generation of readers to African literature'.",
                   BirthDate = DateTime.Parse("1977-09-15"),
                   Country = "Nigeria",
                   ImageUrl = "/images/author/chimamanda_ngozi_adichie.jpeg"
               }, new Author
               {
                   AuthorId = 14,
                   AuthorName = "Neil Gaiman",
                   Biography = "Neil Gaiman is an English author of short fiction, novels, comic books, graphic novels, nonfiction, audio theatre, and films. His works include the comic book series The Sandman and novels Stardust, American Gods, Coraline, and The Graveyard Book.",
                   BirthDate = DateTime.Parse("1960-11-10"),
                   Country = "United Kingdom",
                   ImageUrl = "/images/author/neil_gaiman.jpeg"
               }, new Author
               {
                   AuthorId = 15,
                   AuthorName = "Virginia Woolf",
                   Biography = "Virginia Woolf was an English writer, considered one of the most important modernist 20th-century authors and also a pioneer in the use of stream of consciousness as a narrative device. Woolf was a significant figure in London literary society and a member of the Bloomsbury Group.",
                   BirthDate = DateTime.Parse("1882-01-25"),
                   Country = "United Kingdom",
                   ImageUrl = "/images/author/virginia_woolf.jpeg"
               }, new Author
               {
                   AuthorId = 16,
                   AuthorName = "Hermann Hesse",
                   Biography = "Hermann Hesse was a German-Swiss poet, novelist, and painter. His best-known works include Steppenwolf, Siddhartha, and The Glass Bead Game, each of which explores an individual's search for authenticity, self-knowledge, and spirituality.",
                   BirthDate = DateTime.Parse("1877-07-02"),
                   Country = "Germany",
                   ImageUrl = "/images/author/hermann_hesse.jpeg"
               }, new Author
               {
                   AuthorId = 17,
                   AuthorName = "Agatha Christie",
                   Biography = "Agatha Christie was an English writer known for her sixty-six detective novels and fourteen short story collections, particularly those revolving around fictional detectives Hercule Poirot and Miss Marple.",
                   BirthDate = DateTime.Parse("1890-09-15"),
                   Country = "United Kingdom",
                   ImageUrl = "/images/author/agatha_christie.jpeg"
               }, new Author
               {
                   AuthorId = 18,
                   AuthorName = "Octavia E. Butler",
                   Biography = "Octavia E. Butler was an American science fiction writer. A multiple recipient of both the Hugo and Nebula awards, she became in 1995 the first science-fiction writer to receive a MacArthur Fellowship.",
                   BirthDate = DateTime.Parse("1947-06-22"),
                   Country = "United States",
                   ImageUrl = "/images/author/octavia_e_butler.jpeg"
               }

            );
            modelBuilder.Entity<Book>().HasData(
                 new Book
                 {
                     BookId = 1,
                     Title = "American Gods",
                     AuthorId = 9,
                     Price = 15.99m,
                     QuantityAvailable = 20,
                     ImageUrl = "/images/book/american_gods.jpeg"
                 }, new Book
                 {
                     BookId = 2,
                     Title = "Stardust",
                     AuthorId = 9,
                     Price = 12.99m,
                     QuantityAvailable = 25,
                     ImageUrl = "/images/book/stardust.jpeg"
                 },
    // Books for Virginia Woolf
    new Book
    {
        BookId = 3,
        Title = "To the Lighthouse",
        AuthorId = 10,
        Price = 9.99m,
        QuantityAvailable = 15,
        ImageUrl = "/images/book/to_the_lighthouse.jpeg"
    },
    new Book
    {
        BookId = 4,
        Title = "Mrs. Dalloway",
        AuthorId = 10,
        Price = 10.99m,
        QuantityAvailable = 18,
        ImageUrl = "/images/book/mrs_dalloway.jpeg"
    },
    // Books for Hermann Hesse
    new Book
    {
        BookId = 5,
        Title = "Siddhartha",
        AuthorId = 11,
        Price = 8.99m,
        QuantityAvailable = 22,
        ImageUrl = "/images/book/siddhartha.jpeg"
    },
    new Book
    {
        BookId = 6,
        Title = "Steppenwolf",
        AuthorId = 11,
        Price = 11.50m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/steppenwolf.jpeg"
    },
    // Books for Agatha Christie
    new Book
    {
        BookId = 7,
        Title = "Murder on the Orient Express",
        AuthorId = 12,
        Price = 7.99m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/murder_on_the_orient_express.jpeg"
    },
    new Book
    {
        BookId = 8,
        Title = "And Then There Were None",
        AuthorId = 12,
        Price = 6.99m,
        QuantityAvailable = 28,
        ImageUrl = "/images/book/and_then_there_were_none.jpeg"
    },
    // Books for Octavia E. Butler
    new Book
    {
        BookId = 9,
        Title = "Kindred",
        AuthorId = 13,
        Price = 13.99m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/kindred.jpeg"
    },
    new Book
    {
        BookId = 10,
        Title = "Parable of the Sower",
        AuthorId = 13,
        Price = 14.50m,
        QuantityAvailable = 15,
        ImageUrl = "/images/book/parable_of_the_sower.jpeg"
    },
                new Book
                {
                    BookId = 11,
                    Title = "The House on Mango Street",
                    AuthorId = 1, // Assuming the author ID is 1 for Sandra Cisneros
                    Price = 10.99m,
                    QuantityAvailable = 50,
                    ImageUrl = "1.png"
                },

    new Book
    {
        BookId = 12,
        Title = "Caramelo",
        AuthorId = 1,
        Price = 12.50m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/caramelo.jpeg"
    },
    new Book
    {
        BookId = 13,
        Title = "Woman Hollering Creek and Other Stories",
        AuthorId = 1,
        Price = 9.99m,
        QuantityAvailable = 40,
        ImageUrl = "/images/book/woman_hollering_creek.jpeg"
    },
    // Books for Sarah J. Maas
    new Book
    {
        BookId = 14,
        Title = "Throne of Glass",
        AuthorId = 3,
        Price = 11.99m,
        QuantityAvailable = 35,
        ImageUrl = "/images/book/throne_of_glass.jpeg"
    },
    new Book
    {
        BookId = 15,
        Title = "A Court of Thorns and Roses",
        AuthorId = 3,
        Price = 14.99m,
        QuantityAvailable = 25,
        ImageUrl = "/images/book/a_court_of_thorns_and_roses.jpeg"
    },
    new Book
    {
        BookId = 16,
        Title = "Crescent City: House of Earth and Blood",
        AuthorId = 3,
        Price = 16.99m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/crescent_city.jpeg"
    },
    // Books for Leigh Bardugo
    new Book
    {
        BookId = 17,
        Title = "Shadow and Bone",
        AuthorId = 4,
        Price = 13.99m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/shadow_and_bone.jpeg"
    },
    new Book
    {
        BookId = 18,
        Title = "Six of Crows",
        AuthorId = 4,
        Price = 15.99m,
        QuantityAvailable = 25,
        ImageUrl = "/images/book/six_of_crows.jpeg"
    },
    new Book
    {
        BookId = 19,
        Title = "King of Scars",
        AuthorId = 4,
        Price = 14.50m,
        QuantityAvailable = 28,
        ImageUrl = "/images/book/king_of_scars.jpeg"
    },
    // Books for Cassandra Clare
    new Book
    {
        BookId = 20,
        Title = "City of Bones",
        AuthorId = 5,
        Price = 11.99m,
        QuantityAvailable = 40,
        ImageUrl = "/images/book/city_of_bones.jpeg"
    },
    new Book
    {
        BookId = 21,
        Title = "Clockwork Angel",
        AuthorId = 5,
        Price = 10.99m,
        QuantityAvailable = 35,
        ImageUrl = "/images/book/clockwork_angel.jpeg"
    },
    new Book
    {
        BookId = 22,
        Title = "Lady Midnight",
        AuthorId = 5,
        Price = 12.50m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/lady_midnight.jpeg"
    }, new Book
    {
        BookId = 23,
        Title = "One Hundred Years of Solitude",
        AuthorId = 2, // Assuming the author ID is 2 for Gabriel Garcia Marquez
        Price = 12.50m,
        QuantityAvailable = 30,
        ImageUrl = "1.png"
    }

            );
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    Username = "john_doe",
                    Password = "password123",
                    Email = "john_doe@example.com",
                    FullName = "John Doe",
                    Address = "123 Main St, Anytown, USA",
                    PhoneNumber = "123-456-7890"
                },
                new Customer
                {
                    CustomerId = 2,
                    Username = "jane_smith",
                    Password = "password456",
                    Email = "jane_smith@example.com",
                    FullName = "Jane Smith",
                    Address = "456 Oak St, Anycity, USA",
                    PhoneNumber = "987-654-3210"
                }
            );
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    OrderId = 1,
                    CustomerId = 1, // Assuming customer ID 1 belongs to John Doe
                    OrderDate = DateTime.Now,
                    TotalAmount = 10.99m // Assuming a single order with a total amount of $10.99
                },
                new Order
                {
                    OrderId = 2,
                    CustomerId = 2, // Assuming customer ID 2 belongs to Jane Smith
                    OrderDate = DateTime.Now.AddDays(-1), // Assuming the order was placed one day ago
                    TotalAmount = 25.00m // Assuming a single order with a total amount of $25.00
                }
            );
            modelBuilder.Entity<OrderItem>().HasData(
      new OrderItem
      {
          OrderItemId = 1,
          OrderId = 1, // Assuming order ID 1 belongs to John Doe
          BookId = 1, // Assuming book ID 1 is "The House on Mango Street"
          Quantity = 1,
          PricePerUnit = 10.99m // Assuming the price per unit of "The House on Mango Street"
      },
      new OrderItem
      {
          OrderItemId = 2,
          OrderId = 2, // Assuming order ID 2 belongs to Jane Smith
          BookId = 2, // Assuming book ID 2 is "One Hundred Years of Solitude"
          Quantity = 2,
          PricePerUnit = 12.50m // Assuming the price per unit of "One Hundred Years of Solitude"
      }
  );


            base.OnModelCreating(modelBuilder);
        }

    }
}
