using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;

namespace MVC_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        public AccountController(UserManager<ApplicationUser> UserManager, SignInManager<ApplicationUser> SignInManager)
        {
            userManager = UserManager;
            signInManager = SignInManager;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Register(RegisterUserViewModel UserVM)
        //{
        //    if (ModelState.IsValid == true)
        //    {
        //        save
        //        ApplicationUser user = new ApplicationUser()
        //        {
        //            UserName = UserVM.UserName,
        //            Email = UserVM.Email,
        //            PasswordHash = UserVM.Password,
        //            Address = UserVM.Address
        //        };

        //        IdentityResult result = await userManager.CreateAsync(user, UserVM.Password);
        //        if (result.Succeeded)
        //        {
        //            await signInManager.SignInAsync(user, false);
        //            return RedirectToAction("BasePage", "Home");
        //            createCookie
        //        }
        //        foreach (var item in result.Errors)
        //            ModelState.AddModelError("", item.Description);

        //        createCookie

        //    }
        //    return View("Register", UserVM);
        //}
    }
}
