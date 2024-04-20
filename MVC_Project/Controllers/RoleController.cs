using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using MVC_Project.ViewModel;

namespace MVC_Project.Controllers
{
     [Authorize(Roles ="Admin")]
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        BookStoreContext bookStoreContext;
        ICustomer customerModel;
        public RoleController(RoleManager<IdentityRole> RoleManager, UserManager<ApplicationUser> _userManager,
            SignInManager<ApplicationUser> SignInManager, BookStoreContext _bookStoreContext, ICustomer customer)
        {

            roleManager = RoleManager;
            userManager = _userManager;
            signInManager = SignInManager;
            bookStoreContext = _bookStoreContext;
            customerModel = customer;
        }
		[Authorize(Roles = "Admin")]
		public IActionResult AddRole()
        {
            return View("AddRole");
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel NewRoleVM)
        {
            if (ModelState.IsValid)
            {
                IdentityRole roleModel = new IdentityRole()
                {
                    Name = NewRoleVM.Name,
                };
                IdentityResult Result = await roleManager.CreateAsync(roleModel);
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

		[Authorize(Roles = "Admin")]
		public IActionResult AssignRole()
        {
            var roles = roleManager.Roles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList();

           
            ViewBag.Roles = roles;
            return View("AssignRole");
        }
        [HttpPost]
		[Authorize(Roles = "Admin")]
		public async Task<IActionResult> AssignRole(AssignRoleViewModel UserVM)
        {
            if (ModelState.IsValid == true)
            {

                
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
                    IdentityResult ResultRole = await userManager.AddToRoleAsync(user, UserVM.role);//to register user as admin
                    await signInManager.SignInAsync(user, false);
                    Customer customer = new Customer()
                    {
                        Username = user.UserName,
                        FullName = user.UserName,
                        Password = user.PasswordHash,
                        Email = user.Email,
                        Address = user.Address,
                        ApplicationUserId = user.Id
                    };
                    customerModel.InsertCustomer(customer);
                    customerModel.Save();
                    user.CustomerID = customer.CustomerId;
                    IdentityResult resultUpdate = await userManager.UpdateAsync(user);
                    TempData["SuccessMessage"] = "Role saved successfully.";

                    var roles1 = roleManager.Roles.Select(r => new SelectListItem
                    {
                        Value = r.Name,
                        Text = r.Name
                    }).ToList();


                    ViewBag.Roles = roles1;
                    return View("AssignRole");

                }


                foreach (var item in result.Errors)
                    ModelState.AddModelError("", item.Description);

             
            }

            var roles = roleManager.Roles.Select(r => new SelectListItem
            {
                Value = r.Name,
                Text = r.Name
            }).ToList();


            ViewBag.Roles = roles;
            return View("AssignRole");
        }






    }

}