using Microsoft.AspNetCore.Mvc;

namespace MVC_Project.Controllers
{
    public class CartController : Controller
    {
        

        public IActionResult SelectedBooks([FromBody] int[] selectedBooksID)
        {
            // Store selectedBooksID in TempData to pass it to the view
            TempData["SelectedBooksID"] = selectedBooksID;
            // Return a JSON response indicating success
            return Json(new { success = true });
        }

        public IActionResult DisplayProduct()
        {
            // Retrieve selectedBooksID from TempData and pass it to the view
            var selectedBooksID = TempData["SelectedBooksID"] as int[];
            return View(selectedBooksID ?? new int[0]); // Return an empty array if null
        }


    }
}
