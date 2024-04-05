using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using MVC_Project.ViewModel;

namespace MVC_Project.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
		BookStoreContext bookStoreContext;
		ICustomer customerModel;

		public AccountController(UserManager<ApplicationUser> UserManager,
            SignInManager<ApplicationUser> SignInManager, BookStoreContext _bookStoreContext, ICustomer customer)

		{
            userManager = UserManager;
            signInManager = SignInManager;
            bookStoreContext = _bookStoreContext;
            customerModel = customer;
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
                   // IdentityResult ResultRole = await userManager.AddToRoleAsync(user, "Admin");//to register user as admin
                    await signInManager.SignInAsync(user, false);
					Customer customer = new Customer()
					{
						Username = user.UserName,
                        FullName=user.UserName,
						Password = user.PasswordHash,
						Email = user.Email,
						Address = user.Address,
						ApplicationUserId = user.Id
					};
					customerModel.InsertCustomer(customer);
                    customerModel.Save();
					user.CustomerID = customer.CustomerId;
					IdentityResult resultUpdate = await userManager.UpdateAsync(user);
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

                        return RedirectToAction("Index","Home");

                    }
                }
                ModelState.AddModelError("", "Invalid Account");
            }
            return View(UserVM);
        }
        public async Task<IActionResult> SignOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
