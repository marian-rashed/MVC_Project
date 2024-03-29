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
                    Country = "United States"
                },
                new Author
                {
                    AuthorId = 2,
                    AuthorName = "Gabriel Garcia Marquez",
                    Biography = "Gabriel García Márquez was a Colombian novelist, short-story writer, screenwriter, and journalist, known affectionately as Gabo or Gabito throughout Latin America.",
                    BirthDate = DateTime.Parse("1927-03-06"),
                    Country = "Colombia"
                },
                new Author
                {
                    AuthorId = 3,
                    AuthorName = "Sarah J. Maas",
                    Biography = "Sarah J. Maas is the #1 New York Times and internationally bestselling author of the Crescent City, A Court of Thorns and Roses, and the Throne of Glass series. Her books have sold more than twelve million copies and are published in thirty-seven languages. A New York native, Sarah lives in Philadelphia with her husband, son, and dog. To find out more, visit sarahjmaas.com or follow @therealsjmaas on Instagram.",
                    BirthDate = DateTime.Parse("1986 -03-05"),
                    Country = "United States"
                }

            ); ;
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "The House on Mango Street",
                    AuthorId = 1, // Assuming the author ID is 1 for Sandra Cisneros
                    Price = 10.99m,
                    QuantityAvailable = 50
                },
                new Book
                {
                    BookId = 2,
                    Title = "One Hundred Years of Solitude",
                    AuthorId = 2, // Assuming the author ID is 2 for Gabriel Garcia Marquez
                    Price = 12.50m,
                    QuantityAvailable = 30
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
