using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;

namespace MVC_Project.Controllers
{
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

        //[HttpGet]
        //public IActionResult AddNewCustomer(Customer customer)
        //{
        //    return View("AddNewCustomer");
        //}
        //[HttpPost]
        //public IActionResult SaveCustomer(Customer cust)
        //{
        //    if (ModelState.IsValid == false)
        //    {
        //        return View("AddNewCustomer", cust);
        //    }
        //    customer.InsertCustomer(cust);
        //    customer.Save();

        //    return RedirectToAction("Index");
        //}

    }
}
