using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
	public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
