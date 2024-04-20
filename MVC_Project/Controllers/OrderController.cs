using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using MVC_Project.ViewModel;

namespace MVC_Project.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrder order;
        private readonly IBook bookRepository;
        private readonly UserManager<ApplicationUser> userManager;
        public OrderController(IOrder order, IBook _bookRepository, UserManager<ApplicationUser> _userManager)
        {
            this.order = order;
            bookRepository = _bookRepository;
            this.userManager = _userManager;
        }

        public IActionResult Index()
        {
            List<OrderWithCustomerAndOrderListVM> orderList = order.GetAllOrdersWithCustomerAndOrderList();
            return View("Index", orderList);
        }

        public IActionResult GetOrderById(int id)
        {
            OrderWithCustomerAndOrderListVM orderVM = order.GetOrderByIdWithCustomerAndOrderList(id);
            return View("GetOrderById", orderVM);
        }

        //[HttpGet]
        //public IActionResult AddNewOrder()
        //{
        //    return View("AddNewOrder");
        //}

        [HttpPost]
        //public IActionResult SaveOrder(OrderWithCustomerAndOrderListVM orderVM)
        //{
        //    if (ModelState.IsValid)
        //    {
        //       order.InsertOrder(orderVM);
        //       order.Save();
        //        return RedirectToAction("Index");

        //    }
        //    return View("AddNewOrder", orderVM);

        //}

        public IActionResult SaveOrder(Order ord)
        {
            Order ordVM = new Order();
            ordVM.Customer.FullName = ord.Customer.FullName;
            ordVM.OrderDate = ord.OrderDate;
            ordVM.TotalAmount = ord.TotalAmount;
            ordVM.OrderItems = ord.OrderItems.ToList();
            if (ModelState.IsValid)
            {
                order.InsertOrder(ordVM);
                order.Save();
                return RedirectToAction("Index");

            }
            return View("AddNewOrder", ordVM);
        }

        public IActionResult GetOrdersByCustomerName(string customerName)
        {
            List<OrderWithCustomerAndOrderListVM> orders = order.GetOrdersByCustomerName(customerName);
            return View("GetOrdersByCustomerName", orders);
        }
        public IActionResult GetOrderByCustomerId(string customerId)
        {
            List<OrderWithCustomerAndOrderListVM> orders = order.GetOrderByCustomerId(customerId);
            return View("GetOrderByCustomerId", orders);
        }

        //save order to database

        public IActionResult addorder([FromBody] Dictionary<string, List<int>> postData)
        {
            if (postData != null && postData.ContainsKey("bookIds"))
            {
                List<int> bookIds = postData["bookIds"];
                List<Book> books = new List<Book>();

                foreach (int bookId in bookIds)
                {
                    books.Add(bookRepository.GetBookById(bookId));
                }
                foreach (Book book in books)
                {
                    book.QuantityAvailable--;
                    bookRepository.UpdateBook(book);
                    bookRepository.Save();
                }
                Order newOrder = new Order();
                // newOrder.CustomerId=
                // order.InsertOrder()
                return Json(new { success = true, message = "Order added successfully" });
            }


            return Json(new { success = false, message = "Invalid request data" });
        }

    }


}
