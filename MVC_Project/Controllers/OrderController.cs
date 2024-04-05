using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
