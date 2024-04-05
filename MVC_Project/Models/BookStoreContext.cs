using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Models;

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
			modelBuilder.Entity<ApplicationUser>()
			   .HasOne(u => u.Customer)
			   .WithOne(c => c.ApplicationUser)
			   .HasForeignKey<Customer>(c => c.ApplicationUserId);
			modelBuilder.Entity<Author>().HasData(
    new Author
    {
        AuthorId = 1,
        AuthorName = "Sandra Cisneros",
        Biography = "Sandra Cisneros is an American writer best known for her acclaimed first novel The House on Mango Street.",
        BirthDate = DateTime.Parse("1954-12-20"),
        Country = "United States",
        ImageUrl = "/images/author/Sandra_Cisneros.jpg"
    },
    new Author
    {
        AuthorId = 2,
        AuthorName = "Gabriel García Márquez",
        Biography = "Gabriel García Márquez was a Colombian novelist, short-story writer, screenwriter, and journalist, known affectionately as Gabo throughout Latin America. He is considered one of the most significant authors of the 20th century.",
        BirthDate = DateTime.Parse("1927-03-06"),
        Country = "Colombia",
        ImageUrl = "/images/author/Gabriel_Garcia_Marquez.jpg"
    },
    new Author
    {
        AuthorId = 3,
        AuthorName = "Sarah J. Maas",
        Biography = "Sarah J. Maas is the #1 New York Times and internationally bestselling author of the Crescent City, A Court of Thorns and Roses, and the Throne of Glass series. Her books have sold more than twelve million copies and are published in thirty-seven languages. A New York native, Sarah lives in Philadelphia with her husband, son, and dog. To find out more, visit sarahjmaas.com or follow @therealsjmaas on Instagram.",
        BirthDate = DateTime.Parse("1986-03-05"),
        Country = "United States",
        ImageUrl = "/images/author/Sarah_ J_Maas.jpeg"
    },
    new Author
    {
        AuthorId = 4,
        AuthorName = "Leigh Bardugo",
        Biography = "Leigh Bardugo is an American fantasy author. She is best known for her young adult Grishaverse novels, which include the Shadow and Bone trilogy and the Six of Crows and King of Scars duologies. She also received acclaim for her paranormal fantasy adult debut, Ninth House",
        BirthDate = DateTime.Parse("1975-04-06"),
        Country = "United States",
        ImageUrl = "/images/author/Leigh_Bardugo.jpeg"
    },
    new Author
    {
        AuthorId = 5,
        AuthorName = "Cassandra Clare",
        Biography = "Judith Lewis, better known by her pen name Cassandra Clare, is an American author of young adult fiction, best known for her bestselling series The Mortal Instruments.",
        BirthDate = DateTime.Parse("1975-04-06"),
        Country = "United States",
        ImageUrl = "/images/author/Cassandra_Clare.jpeg"
    },
    new Author
    {
        AuthorId = 6,
        AuthorName = "J.K. Rowling",
        Biography = "J.K. Rowling is a British author, philanthropist, film producer, television producer, and screenwriter. She is best known for writing the Harry Potter fantasy series, which has won multiple awards and sold more than 500 million copies, becoming the best-selling book series in history.",
        BirthDate = DateTime.Parse("1965-07-31"),
        Country = "United Kingdom",
        ImageUrl = "/images/author/jk rowling.jpg"
    },
    new Author
    {
        AuthorId = 7,
        AuthorName = "Stephen King",
        Biography = "Stephen King is an American author of horror, supernatural fiction, suspense, crime, science-fiction, and fantasy novels. His books have sold more than 350 million copies, and many have been adapted into films, television series, miniseries, and comic books.",
        BirthDate = DateTime.Parse("1947-09-21"),
        Country = "United States",
        ImageUrl = "/images/author/Stephen_king.jpg"
    },
    new Author
    {
        AuthorId = 8,
        AuthorName = "Haruki Murakami",
        Biography = "Haruki Murakami is a Japanese writer. His books and stories have been bestsellers in Japan and internationally, with his work being translated into 50 languages and selling millions of copies outside his native country.",
        BirthDate = DateTime.Parse("1949-01-12"),
        Country = "Japan",
        ImageUrl = "/images/author/Haruki_Murakami.jpeg"
    },
    new Author
    {
        AuthorId = 9,
        AuthorName = "Margaret Atwood",
        Biography = "Margaret Atwood is a Canadian poet, novelist, literary critic, essayist, inventor, teacher, and environmental activist. She has published over 17 books of poetry, 16 novels, 10 books of non-fiction, 8 collections of short fiction, 8 children's books, and 1 graphic novel.",
        BirthDate = DateTime.Parse("1939-11-18"),
        Country = "Canada",
        ImageUrl = "/images/author/Margaret_Atwood.jpg"
    },
    new Author
    {
        AuthorId = 10,
        AuthorName = "George R.R. Martin",
        Biography = "George R.R. Martin is an American novelist and short story writer, screenwriter, and television producer. He is best known for his series of epic fantasy novels, A Song of Ice and Fire, which was adapted into the HBO series Game of Thrones.",
        BirthDate = DateTime.Parse("1948-09-20"),
        Country = "United States",
        ImageUrl = "/images/author/George_R_R_Martin.jpg"
    },
    new Author
    {
        AuthorId = 11,
        AuthorName = "Toni Morrison",
        Biography = "Toni Morrison was an American novelist, essayist, editor, teacher, and professor emeritus at Princeton University. She won the Pulitzer Prize and the American Book Award in 1988 for Beloved.",
        BirthDate = DateTime.Parse("1931-02-18"),
        Country = "United States",
        ImageUrl = "/images/author/Toni_Morrison.jpg"
    },
    new Author
    {
        AuthorId = 12,
        AuthorName = "Chimamanda Ngozi Adichie",
        Biography = "Chimamanda Ngozi Adichie is a Nigerian writer whose works range from novels to short stories to nonfiction. She was described in The Times Literary Supplement as 'the most prominent' of a 'procession of critically acclaimed young anglophone authors [which] is succeeding in attracting a new generation of readers to African literature'.",
        BirthDate = DateTime.Parse("1977-09-15"),
        Country = "Nigeria",
        ImageUrl = "/images/author/Chimamanda_Ngozi_Adichie.jpg"
    },
    new Author
    {
        AuthorId = 13,
        AuthorName = "Neil Gaiman",
        Biography = "Neil Gaiman is an English author of short fiction, novels, comic books, graphic novels, nonfiction, audio theatre, and films. His works include the comic book series The Sandman and novels Stardust, American Gods, Coraline, and The Graveyard Book.",
        BirthDate = DateTime.Parse("1960-11-10"),
        Country = "United Kingdom",
        ImageUrl = "/images/author/Neil_Gaiman.jpg"
    },
    new Author
    {
        AuthorId = 14,
        AuthorName = "Virginia Woolf",
        Biography = "Virginia Woolf was an English writer, considered one of the most important modernist 20th-century authors and also a pioneer in the use of stream of consciousness as a narrative device. Woolf was a significant figure in London literary society and a member of the Bloomsbury Group.",
        BirthDate = DateTime.Parse("1882-01-25"),
        Country = "United Kingdom",
        ImageUrl = "/images/author/Virginia _Wolf.jpeg"
    },
    new Author
    {
        AuthorId = 15,
        AuthorName = "Hermann Hesse",
        Biography = "Hermann Hesse was a German-Swiss poet, novelist, and painter. His best-known works include Steppenwolf, Siddhartha, and The Glass Bead Game, each of which explores an individual's search for authenticity, self-knowledge, and spirituality.",
        BirthDate = DateTime.Parse("1877-07-02"),
        Country = "Germany",
        ImageUrl = "/images/author/Hermman_Hesse.jpg"
    },
    new Author
    {
        AuthorId = 16,
        AuthorName = "Agatha Christie",
        Biography = "Agatha Christie was an English writer known for her sixty-six detective novels and fourteen short story collections, particularly those revolving around fictional detectives Hercule Poirot and Miss Marple.",
        BirthDate = DateTime.Parse("1890-09-15"),
        Country = "United Kingdom",
        ImageUrl = "/images/author/Agatha_Christie.jpg"
    },
    new Author
    {
        AuthorId = 17,
        AuthorName = "Octavia E. Butler",
        Biography = "Octavia E. Butler was an American science fiction writer. A multiple recipient of both the Hugo and Nebula awards, she became in 1995 the first science-fiction writer to receive a MacArthur Fellowship.",
        BirthDate = DateTime.Parse("1947-06-22"),
        Country = "United States",
        ImageUrl = "/images/author/Octivia_Butler.jpeg"
    },
    new Author
    {
        AuthorId = 18,
        AuthorName = "Ernest Hemingway",
        Biography = "Ernest Hemingway was an American novelist, short-story writer, journalist, and sportsman. His economical and understated style—which he termed the iceberg theory—had a strong influence on 20th-century fiction, while his adventurous lifestyle and his public image brought him admiration from later generations.",
        BirthDate = DateTime.Parse("1899-07-21"),
        Country = "United States",
        ImageUrl = "/images/author/Ernest_Hemingway.jpg"
    },
    new Author
    {
        AuthorId = 19,
        AuthorName = "J.R.R. Tolkien",
        Biography = "J.R.R. Tolkien was an English writer, poet, philologist, and university professor. He was best known as the author of the classic high fantasy works The Hobbit, The Lord of the Rings, and The Silmarillion.",
        BirthDate = DateTime.Parse("1892-01-03"),
        Country = "United Kingdom",
        ImageUrl = "/images/author/JRR Tolkin.jpeg"
    }
);

            modelBuilder.Entity<Book>().HasData(
    new Book
    {
        BookId = 1,
        Title = "The House on Mango Street",
        AuthorId = 1, // Sandra Cisneros
        Price = 10.99m,
        QuantityAvailable = 50,
        ImageUrl = "/images/book/the_house_on_mango_street.jpeg"
    },
    new Book
    {
        BookId = 2,
        Title = "Caramelo",
        AuthorId = 1, // Sandra Cisneros
        Price = 12.50m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/caramelo.jpeg"
    },
    new Book
    {
        BookId = 3,
        Title = "Woman Hollering Creek and Other Stories",
        AuthorId = 1, // Sandra Cisneros
        Price = 9.99m,
        QuantityAvailable = 40,
        ImageUrl = "/images/book/woman_hollering_creek.jpeg"
    },
    new Book
    {
        BookId = 4,
        Title = "One Hundred Years of Solitude",
        AuthorId = 2, // Gabriel García Márquez
        Price = 12.50m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/one_hundred_years_of_solitude.jpeg"
    },
    new Book
    {
        BookId = 5,
        Title = "Throne of Glass",
        AuthorId = 3, // Sarah J. Maas
        Price = 11.99m,
        QuantityAvailable = 35,
        ImageUrl = "/images/book/throne_of_glass.jpeg"
    },
    new Book
    {
        BookId = 6,
        Title = "A Court of Thorns and Roses",
        AuthorId = 3, // Sarah J. Maas
        Price = 14.99m,
        QuantityAvailable = 25,
        ImageUrl = "/images/book/a_court_of_thorns_and_roses.jpeg"
    },
    new Book
    {
        BookId = 7,
        Title = "Crescent City: House of Earth and Blood",
        AuthorId = 3, // Sarah J. Maas
        Price = 16.99m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/crescent_city.jpeg"
    }, new Book
    {
        BookId = 8,
        Title = "Shadow and Bone",
        AuthorId = 4, // Leigh Bardugo
        Price = 13.99m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/shadow_and_bone.jpeg"
    },
    new Book
    {
        BookId = 9,
        Title = "Six of Crows",
        AuthorId = 4, // Leigh Bardugo
        Price = 15.99m,
        QuantityAvailable = 25,
        ImageUrl = "/images/book/six_of_crows.jpeg"
    },
    new Book
    {
        BookId = 10,
        Title = "King of Scars",
        AuthorId = 4, // Leigh Bardugo
        Price = 14.50m,
        QuantityAvailable = 28,
        ImageUrl = "/images/book/king_of_scars.jpeg"
    },
    new Book
    {
        BookId = 11,
        Title = "City of Bones",
        AuthorId = 5, // Cassandra Clare
        Price = 11.99m,
        QuantityAvailable = 40,
        ImageUrl = "/images/book/city_of_bones.jpeg"
    },
    new Book
    {
        BookId = 12,
        Title = "Clockwork Angel",
        AuthorId = 5, // Cassandra Clare
        Price = 10.99m,
        QuantityAvailable = 35,
        ImageUrl = "/images/book/clockwork_angel.jpeg"
    },
    new Book
    {
        BookId = 13,
        Title = "Lady Midnight",
        AuthorId = 5, // Cassandra Clare
        Price = 12.50m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/lady_midnight.jpeg"
    },
    new Book
    {
        BookId = 14,
        Title = "American Gods",
        AuthorId = 13, // Neil Gaiman
        Price = 15.99m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/american_gods.jpeg"
    },
    new Book
    {
        BookId = 15,
        Title = "Stardust",
        AuthorId = 13, // Neil Gaiman
        Price = 12.99m,
        QuantityAvailable = 25,
        ImageUrl = "/images/book/stardust.jpeg"
    },
    new Book
    {
        BookId = 16,
        Title = "To the Lighthouse",
        AuthorId = 14, // Virginia Woolf
        Price = 9.99m,
        QuantityAvailable = 15,
        ImageUrl = "/images/book/to_the_lighthouse.jpeg"
    },
    new Book
    {
        BookId = 17,
        Title = "Mrs. Dalloway",
        AuthorId = 14, // Virginia Woolf
        Price = 10.99m,
        QuantityAvailable = 18,
        ImageUrl = "/images/book/mrs_dalloway.jpeg"
    },
    new Book
    {
        BookId = 18,
        Title = "Siddhartha",
        AuthorId = 15, // Hermann Hesse
        Price = 8.99m,
        QuantityAvailable = 22,
        ImageUrl = "/images/book/siddhartha.jpeg"
    },
    new Book
    {
        BookId = 19,
        Title = "Steppenwolf",
        AuthorId = 15, // Hermann Hesse
        Price = 11.50m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/steppenwolf.jpeg"
    },
    new Book
    {
        BookId = 20,
        Title = "Murder on the Orient Express",
        AuthorId = 16, // Agatha Christie
        Price = 7.99m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/murder_on_the_orient_express.jpeg"
    },
    new Book
    {
        BookId = 21,
        Title = "And Then There Were None",
        AuthorId = 16, // Agatha Christie
        Price = 6.99m,
        QuantityAvailable = 28,
        ImageUrl = "/images/book/and_then_there_were_none.jpeg"
    },
    new Book
    {
        BookId = 22,
        Title = "Kindred",
        AuthorId = 17, // Octavia E. Butler
        Price = 13.99m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/kindred.jpeg"
    },
    new Book
    {
        BookId = 23,
        Title = "Parable of the Sower",
        AuthorId = 17, // Octavia E. Butler
        Price = 14.50m,
        QuantityAvailable = 15,
        ImageUrl = "/images/book/parable_of_the_sower.jpeg"
    },
    new Book
    {
        BookId = 24,
        Title = "The Old Man and the Sea",
        AuthorId = 18, // Ernest Hemingway
        Price = 8.99m,
        QuantityAvailable = 25,
        ImageUrl = "/images/book/the_old_man_and_the_sea.jpeg"
    },
    new Book
    {
        BookId = 25,
        Title = "A Farewell to Arms",
        AuthorId = 18, // Ernest Hemingway
        Price = 10.50m,
        QuantityAvailable = 20,
        ImageUrl = "/images/book/a_farewell_to_arms.jpeg"
    },
    new Book
    {
        BookId = 26,
        Title = "For Whom the Bell Tolls",
        AuthorId = 18, // Ernest Hemingway
        Price = 12.99m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/for_whom_the_bell_tolls.jpeg"
    },
    new Book
    {
        BookId = 27,
        Title = "The Hobbit",
        AuthorId = 19, // J.R.R. Tolkien
        Price = 9.99m,
        QuantityAvailable = 40,
        ImageUrl = "/images/book/the_hobbit.jpeg"
    },
    new Book
    {
        BookId = 28,
        Title = "The Fellowship of the Ring",
        AuthorId = 19, // J.R.R. Tolkien
        Price = 11.50m,
        QuantityAvailable = 35,
        ImageUrl = "/images/book/the_fellowship_of_the_ring.jpeg"
    },
    new Book
    {
        BookId = 29,
        Title = "The Silmarillion",
        AuthorId = 19, // J.R.R. Tolkien
        Price = 14.50m,
        QuantityAvailable = 30,
        ImageUrl = "/images/book/the_silmarillion.jpeg"
    }, new Book
    {
        BookId = 30,
        Title = "Harry Potter and the Philosopher's Stone",
        AuthorId = 6, // J.K. Rowling
        Price = 12.99m,
        QuantityAvailable = 25,
        ImageUrl = "/images/book/harry_potter_and_the_philosophers_stone.jpeg"
    },
new Book
{
    BookId = 31,
    Title = "Harry Potter and the Chamber of Secrets",
    AuthorId = 6, // J.K. Rowling
    Price = 13.99m,
    QuantityAvailable = 20,
    ImageUrl = "/images/book/harry_potter_and_the_chamber_of_secrets.jpeg"
},
new Book
{
    BookId = 32,
    Title = "Harry Potter and the Prisoner of Azkaban",
    AuthorId = 6, // J.K. Rowling
    Price = 14.99m,
    QuantityAvailable = 30,
    ImageUrl = "/images/book/harry_potter_and_the_prisoner_of_azkaban.jpeg"
},
new Book
{
    BookId = 33,
    Title = "Harry Potter and the Goblet of Fire",
    AuthorId = 6, // J.K. Rowling
    Price = 15.99m,
    QuantityAvailable = 28,
    ImageUrl = "/images/book/harry_potter_and_the_goblet_of_fire.jpeg"
}, new Book
{
    BookId = 34,
    Title = "The Shining",
    AuthorId = 7, // Stephen King
    Price = 11.99m,
    QuantityAvailable = 20,
    ImageUrl = "/images/book/the_shining.jpeg"
},
new Book
{
    BookId = 35,
    Title = "It",
    AuthorId = 7, // Stephen King
    Price = 14.50m,
    QuantityAvailable = 22,
    ImageUrl = "/images/book/it.jpeg"
}, new Book
{
    BookId = 36,
    Title = "Norwegian Wood",
    AuthorId = 8, // Haruki Murakami
    Price = 12.99m,
    QuantityAvailable = 18,
    ImageUrl = "/images/book/norwegian_wood.jpeg"
},
new Book
{
    BookId = 37,
    Title = "Kafka on the Shore",
    AuthorId = 8, // Haruki Murakami
    Price = 13.50m,
    QuantityAvailable = 20,
    ImageUrl = "/images/book/kafka_on_the_shore.jpeg"
}, new Book
{
    BookId = 38,
    Title = "The Testaments",
    AuthorId = 9, // Margaret Atwood
    Price = 15.99m,
    QuantityAvailable = 22,
    ImageUrl = "/images/book/the_testaments.jpeg"
},
new Book
{
    BookId = 39,
    Title = "Oryx and Crake",
    AuthorId = 9, // Margaret Atwood
    Price = 14.50m,
    QuantityAvailable = 20,
    ImageUrl = "/images/book/oryx_and_crake.jpeg"
}, new Book
{
    BookId = 40,
    Title = "A Clash of Kings",
    AuthorId = 10, // George R.R. Martin
    Price = 12.99m,
    QuantityAvailable = 25,
    ImageUrl = "/images/book/a_clash_of_kings.jpeg"
},
new Book
{
    BookId = 41,
    Title = "A Storm of Swords",
    AuthorId = 10, // George R.R. Martin
    Price = 14.50m,
    QuantityAvailable = 30,
    ImageUrl = "/images/book/a_storm_of_swords.jpeg"
},
new Book
{
    BookId = 42,
    Title = "A Feast for Crows",
    AuthorId = 10, // George R.R. Martin
    Price = 13.99m,
    QuantityAvailable = 28,
    ImageUrl = "/images/book/a_feast_for_crows.jpeg"
}, new Book
{
    BookId = 43,
    Title = "Beloved",
    AuthorId = 11, // Toni Morrison
    Price = 11.99m,
    QuantityAvailable = 20,
    ImageUrl = "/images/book/beloved.jpeg"
}, new Book
{
    BookId = 44,
    Title = "Americanah",
    AuthorId = 12, // Chimamanda Ngozi Adichie
    Price = 13.50m,
    QuantityAvailable = 25,
    ImageUrl = "/images/book/americanah.jpeg"
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
                }, new Customer
                {
                    CustomerId = 3,
                    Username = "mike_jackson",
                    Password = "strongpwd456",
                    Email = "mike_jackson@example.com",
                    FullName = "Mike Jackson",
                    Address = "789 Oak St, Anytown, USA",
                    PhoneNumber = "555-123-4567"
                },
    new Customer
    {
        CustomerId = 4,
        Username = "sarah_adams",
        Password = "mypassword789",
        Email = "sarah_adams@example.com",
        FullName = "Sarah Adams",
        Address = "321 Pine St, Anytown, USA",
        PhoneNumber = "444-222-3333"
    },
    new Customer
    {
        CustomerId = 5,
        Username = "alex_miller",
        Password = "alexpass123",
        Email = "alex_miller@example.com",
        FullName = "Alex Miller",
        Address = "567 Maple St, Anytown, USA",
        PhoneNumber = "111-999-8888"
    },
    new Customer
    {
        CustomerId = 6,
        Username = "emily_taylor",
        Password = "password987",
        Email = "emily_taylor@example.com",
        FullName = "Emily Taylor",
        Address = "246 Birch St, Anytown, USA",
        PhoneNumber = "777-666-5555"
    }, new Customer
    {
        CustomerId = 7,
        Username = "ryan_carter",
        Password = "carterpass456",
        Email = "ryan_carter@example.com",
        FullName = "Ryan Carter",
        Address = "135 Cedar St, Anytown, USA",
        PhoneNumber = "999-777-6666"
    },
    new Customer
    {
        CustomerId = 8,
        Username = "lisa_wilson",
        Password = "secure1234",
        Email = "lisa_wilson@example.com",
        FullName = "Lisa Wilson",
        Address = "753 Walnut St, Anytown, USA",
        PhoneNumber = "222-333-4444"
    },
    new Customer
    {
        CustomerId = 9,
        Username = "david_thompson",
        Password = "davidpass789",
        Email = "david_thompson@example.com",
        FullName = "David Thompson",
        Address = "987 Birch St, Anytown, USA",
        PhoneNumber = "888-555-2222"
    },
    new Customer
    {
        CustomerId = 10,
        Username = "sophia_harris",
        Password = "harrissafe123",
        Email = "sophia_harris@example.com",
        FullName = "Sophia Harris",
        Address = "369 Oak St, Anytown, USA",
        PhoneNumber = "777-888-9999"
    }, new Customer
    {
        CustomerId = 11,
        Username = "mark_johnson",
        Password = "markpass123",
        Email = "mark_johnson@example.com",
        FullName = "Mark Johnson",
        Address = "456 Pine St, Othertown, Canada",
        PhoneNumber = "111-222-3333"
    },
    new Customer
    {
        CustomerId = 12,
        Username = "emily_smith",
        Password = "emilypass456",
        Email = "emily_smith@example.com",
        FullName = "Emily Smith",
        Address = "789 Maple St, Anothertown, Australia",
        PhoneNumber = "444-555-6666"
    },
    new Customer
    {
        CustomerId = 13,
        Username = "alexander_brown",
        Password = "brownsecure123",
        Email = "alexander_brown@example.com",
        FullName = "Alexander Brown",
        Address = "987 Elm St, Yetanothertown, United Kingdom",
        PhoneNumber = "777-888-9999"
    },
    new Customer
    {
        CustomerId = 14,
        Username = "olivia_davis",
        Password = "oliviapass789",
        Email = "olivia_davis@example.com",
        FullName = "Olivia Davis",
        Address = "321 Cedar St, Differenttown, Germany",
        PhoneNumber = "888-999-0000"
    },
    new Customer
    {
        CustomerId = 15,
        Username = "william_taylor",
        Password = "williampass123",
        Email = "william_taylor@example.com",
        FullName = "William Taylor",
        Address = "654 Oak St, Anotherdifferenttown, France",
        PhoneNumber = "222-333-4444"
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
                }, new Order
                {
                    OrderId = 3,
                    CustomerId = 3, // Assuming customer ID 3 belongs to Alice Johnson
                    OrderDate = DateTime.Now.AddDays(-2), // Assuming the order was placed two days ago
                    TotalAmount = 18.50m // Assuming a single order with a total amount of $18.50
                },
    new Order
    {
        OrderId = 4,
        CustomerId = 4,
        OrderDate = DateTime.Now.AddDays(-3), // Assuming the order was placed three days ago
        TotalAmount = 32.75m // Assuming a single order with a total amount of $32.75
    },
    new Order
    {
        OrderId = 5,
        CustomerId = 5,
        OrderDate = DateTime.Now.AddDays(-4), // Assuming the order was placed four days ago
        TotalAmount = 14.99m // Assuming a single order with a total amount of $14.99
    },
    new Order
    {
        OrderId = 6,
        CustomerId = 6,
        OrderDate = DateTime.Now.AddDays(-5), // Assuming the order was placed five days ago
        TotalAmount = 20.25m // Assuming a single order with a total amount of $20.25
    },
    new Order
    {
        OrderId = 7,
        CustomerId = 7,
        OrderDate = DateTime.Now.AddDays(-6), // Assuming the order was placed six days ago
        TotalAmount = 27.50m // Assuming a single order with a total amount of $27.50
    }, new Order
    {
        OrderId = 8,
        CustomerId = 8,
        OrderDate = DateTime.Now.AddDays(-7), // Assuming the order was placed seven days ago
        TotalAmount = 45.75m // Assuming a total amount of $45.75
    },
    new Order
    {
        OrderId = 9,
        CustomerId = 9,
        OrderDate = DateTime.Now.AddDays(-8), // Assuming the order was placed eight days ago
        TotalAmount = 62.99m // Assuming a total amount of $62.99
    },
    new Order
    {
        OrderId = 10,
        CustomerId = 10, // Assuming customer ID 10 belongs to Ethan Anderson
        OrderDate = DateTime.Now.AddDays(-9), // Assuming the order was placed nine days ago
        TotalAmount = 28.50m // Assuming a total amount of $28.50
    },
    new Order
    {
        OrderId = 11,
        CustomerId = 11,
        OrderDate = DateTime.Now.AddDays(-10), // Assuming the order was placed ten days ago
        TotalAmount = 35.99m // Assuming a total amount of $35.99
    },
    new Order
    {
        OrderId = 12,
        CustomerId = 12,
        OrderDate = DateTime.Now.AddDays(-11), // Assuming the order was placed eleven days ago
        TotalAmount = 52.25m // Assuming a total amount of $52.25
    }, new Order
    {
        OrderId = 13,
        CustomerId = 13,
        OrderDate = DateTime.Now.AddDays(-12), // Assuming the order was placed twelve days ago
        TotalAmount = 75.99m // Assuming a total amount of $75.99
    },
    new Order
    {
        OrderId = 14,
        CustomerId = 14,
        OrderDate = DateTime.Now.AddDays(-13), // Assuming the order was placed thirteen days ago
        TotalAmount = 42.75m // Assuming a total amount of $42.75
    },
    new Order
    {
        OrderId = 15,
        CustomerId = 15,
        OrderDate = DateTime.Now.AddDays(-14), // Assuming the order was placed fourteen days ago
        TotalAmount = 55.50m // Assuming a total amount of $55.50
    },
    new Order
    {
        OrderId = 16,
        CustomerId = 12,
        OrderDate = DateTime.Now.AddDays(-15), // Assuming the order was placed fifteen days ago
        TotalAmount = 38.25m // Assuming a total amount of $38.25
    },
    new Order
    {
        OrderId = 17,
        CustomerId = 10,
        OrderDate = DateTime.Now.AddDays(-16), // Assuming the order was placed sixteen days ago
        TotalAmount = 49.99m // Assuming a total amount of $49.99
    },
    new Order
    {
        OrderId = 18,
        CustomerId = 8,
        OrderDate = DateTime.Now.AddDays(-17), // Assuming the order was placed seventeen days ago
        TotalAmount = 65.75m // Assuming a total amount of $65.75
    },
    new Order
    {
        OrderId = 19,
        CustomerId = 6,
        OrderDate = DateTime.Now.AddDays(-18), // Assuming the order was placed eighteen days ago
        TotalAmount = 80.50m // Assuming a total amount of $80.50
    },
    new Order
    {
        OrderId = 20,
        CustomerId = 10,
        OrderDate = DateTime.Now.AddDays(-19), // Assuming the order was placed nineteen days ago
        TotalAmount = 95.25m // Assuming a total amount of $95.25
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
