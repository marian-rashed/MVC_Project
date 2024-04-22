using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;

namespace MVC_Project.Controllers
{
	[Authorize(Roles = "Admin")]
	public class CustomerController : Controller
    {
		
		ICustomer customer;
		
		public CustomerController(ICustomer customer)
        {
            this.customer = customer;
        }
	
		public IActionResult Index()
        {
            List<Customer> CustomerList = customer.GetAllCustomers();
            return View("index", CustomerList);
        }

		public IActionResult GetCustomerById(string id)

        {
            Customer cust = customer.GetCustomerById(id);
            return View("GetCustomerById", cust);
        }
		
		public IActionResult GetCustomersByName(string name)
        {
            var customers = customer.GetCustomersByName(name);
            return View("GetCustomersByName", customers);
        }


    }
}
