using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.ViewModel;

namespace MVC_Project.Controllers
{
    //[Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        public RoleController( RoleManager<IdentityRole>RoleManager) { 

            roleManager = RoleManager;

        }
        public IActionResult AddRole()
        {
            return View("AddRole");
        }
        [HttpPost]
        public async Task <IActionResult> AddRole(RoleViewModel NewRoleVM)
        {
            if (ModelState.IsValid)
            {
                IdentityRole roleModel = new IdentityRole()
                {
                    Name = NewRoleVM.Name,
                };
              IdentityResult Result= await roleManager.CreateAsync(roleModel);
                if (Result.Succeeded)
                {
                   // ViewBag.SuccessMessage = TempData["Role Added Successfully"] as string;
                    TempData["SuccessMessage"] = "Role saved successfully.";

                }
                else
                {
                    //foreach (var item in Result.Errors)
                    //    ModelState.AddModelError("", item.Description);
                }
            }

            return View("AddRole");
        }
    }
}
