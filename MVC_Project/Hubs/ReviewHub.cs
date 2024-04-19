using Microsoft.AspNetCore.SignalR;
using MVC_Project.Models;

namespace MVC_Project.Hubs
{
    public class ReviewHub :Hub
    {
        BookStoreContext bookStoreContext = new BookStoreContext();
        public void SendReview(string name, string message, int bookId)
        {
            var review = new Review
            {
                UserName = name,
                Text = message,
                BookID = bookId
            };
            bookStoreContext.Reviews.Add(review);
             bookStoreContext.SaveChangesAsync();
             Clients.All.SendAsync("RecieveNewComment", name, message, bookId);

        }
    }
}
