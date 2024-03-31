using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Models;
using MVC_Project.ViewModel;

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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel UserVM)
        {
            if (ModelState.IsValid == true)
            {
                //save
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = UserVM.UserName,
                    Email = UserVM.Email,
                    PasswordHash = UserVM.Password,
                    Address = UserVM.Address
                };

                IdentityResult result = await userManager.CreateAsync(user, UserVM.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Login");
                    //createCookie
                }
                foreach (var item in result.Errors)
                    ModelState.AddModelError("", item.Description);

                //createCookie

            }
            return View("Register", UserVM);
        }
        [HttpGet]
        public IActionResult Login()
        {
            /////Mariaaaaaa
            return View("Login");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel UserVM)
        {
            if (ModelState.IsValid == true)
            {
                ApplicationUser userDB = await userManager.FindByNameAsync(UserVM.UserName);
                if (userDB != null)
                {
                    bool found = await userManager.CheckPasswordAsync(userDB, UserVM.Password);
                    if (found)
                    {
                        await signInManager.SignInAsync(userDB, UserVM.RememberMe);
                        return RedirectToAction("index","Home");
                    }
                }
                ModelState.AddModelError("", "Invalid Account");
            }
            return View(UserVM);
        }
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
