
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_Project.Hubs;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using MVC_Project.Repository;
using MVC_Project.Hubs;


namespace MVC_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<BookStoreContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });
            builder.Services.AddScoped<IAuthor, AuthorRepository>();
            builder.Services.AddScoped<IBook, BookRepository>();
            builder.Services.AddScoped<IOrder, OrderRepository>();
            builder.Services.AddScoped<IOrderItem, OrderItemsRepository>();
            builder.Services.AddScoped<ICustomer, CustomerRepository>();





            builder.Services.AddDbContext<BookStoreContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("cs"));
            });
           builder.Services.AddSession(options =>
            {
                options.Cookie.Name = "CartSession";
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout
            });
            _ = builder.Services.AddIdentity<ApplicationUser, IdentityRole>(
               options =>
               {

                   options.Password.RequireNonAlphanumeric = false;
                   options.Password.RequireUppercase = false;
                   options.Password.RequireLowercase = false;
                   options.Password.RequireDigit = false;
                   options.Password.RequireDigit = false;
                   options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                   // Minimum username length of 4 characters


               }).AddEntityFrameworkStores<BookStoreContext>();

            builder.Services.AddControllersWithViews();

            builder.Services.AddSignalR();

            var app = builder.Build();





            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();



            app.MapHub<ReviewsHub>("/ReviewsHub");
            app.MapHub<BookHub>("/BookHub");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
