using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.Models;
using MVC_Project.Repository;
using MVC_Project.ViewModel;


namespace MVC_Project.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {


         private readonly IOrder order;
         private readonly IBook bookRepository;
		private readonly IOrderItem orderItemsRepository;
		private readonly UserManager<ApplicationUser> userManager;
        public OrderController(IOrder order, IBook _bookRepository, UserManager<ApplicationUser> _userManager,
			IOrderItem _orderItemsRepository
			)

        {
            this.order = order;
            bookRepository = _bookRepository;
            this.userManager = _userManager;
            orderItemsRepository= _orderItemsRepository;

        }

        public IActionResult Index()
        {
            List<OrderWithCustomerAndOrderListVM> orderList = order.GetAllOrdersWithCustomerAndOrderList();
            return View("Index", orderList);
        }
		[Authorize(Roles = "Admin")]
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

        public IActionResult thankyou()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
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

        public async Task<IActionResult> addorder([FromBody] Dictionary<string, List<int>> postData)
        {

			ApplicationUser currentUser = await userManager.GetUserAsync(HttpContext.User);
            
                if (postData != null && postData.ContainsKey("bookIds") && currentUser != null)
                {
                    List<int> bookIds = postData["bookIds"];
                    List<Book> books = new List<Book>();
                    decimal totalPrice = 0;
                    foreach (int bookId in bookIds)
                    {
                        books.Add(bookRepository.GetBookById(bookId));
                    }
                    foreach (Book book in books)
                    {
                        totalPrice += book.Price;
                        book.QuantityAvailable--;
                        bookRepository.UpdateBook(book);
                        bookRepository.Save();
                    }


                    string customerID = currentUser.CustomerID;


                    Order newOrder = new Order
                    {
                        CustomerId = customerID,
                        OrderDate = DateTime.Now,
                        TotalAmount = totalPrice,
                    };


                    order.InsertOrder(newOrder);
                    order.Save();

                    ////////////////////////////////save Order Itmes 

                    int orderID = order.getOrderID(newOrder.CustomerId, newOrder.OrderDate);
                    foreach (Book book in books)
                    {
                        OrderItem newOrderItem = new OrderItem
                        {
                            OrderId = orderID,
                            BookId = book.BookId,
                            Quantity = 1,
                            PricePerUnit = book.Price
                        };
                        orderItemsRepository.InsertOrderItems(newOrderItem);
                        orderItemsRepository.Save();

                    }


					return Json(new { success = true, message = "Order added successfully" });

            }



            return Json(new { success = false, message = "Invalid request data" });
        }




    }


}
