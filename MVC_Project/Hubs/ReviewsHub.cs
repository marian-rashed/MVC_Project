using Microsoft.AspNetCore.SignalR;
using Microsoft.CodeAnalysis;
using MVC_Project.Models;

namespace MVC_Project.Hubs
{
	public class ReviewsHub:Hub
	{
		BookStoreContext bookStoreContext = new BookStoreContext();
		public async Task SendReview(string name, string message, int bookId)
		{

			var review = new Review
			{
				UserName = name,
				Text = message,
				BookID = bookId
			};
			bookStoreContext.Reviews.Add(review);
			await bookStoreContext.SaveChangesAsync();
			await Clients.All.SendAsync("RecieveNewComment", name, message, bookId);
			
		}
	}
}
