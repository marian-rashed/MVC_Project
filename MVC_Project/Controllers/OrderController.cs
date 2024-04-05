using Microsoft.AspNetCore.Mvc;
using MVC_Project.Interfaces;
using MVC_Project.ViewModel;

namespace MVC_Project.Controllers
{
    public class OrderController : Controller
    {

        private readonly IOrder order;
        private readonly IOrder orderRepository;

        public OrderController(IOrder order, IOrder orderRepository)
        {
            this.order = order;
            this.orderRepository = orderRepository;
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

        [HttpGet]
        public IActionResult AddNewOrder()
        {
            return View("AddNewOrder");
        }

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
            OrderWithCustomerAndOrderListVM ordVM = new OrderWithCustomerAndOrderListVM();
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
            List<OrderWithCustomerAndOrderListVM> orders = orderRepository.GetOrdersByCustomerName(customerName);
            return View("GetOrdersByCustomerName", orders);
        }
        public IActionResult GetOrderByCustomerId(string customerId)
        {
            List<OrderWithCustomerAndOrderListVM> orders = orderRepository.GetOrderByCustomerId(customerId);
            return View("GetOrderByCustomerId", orders);
        }






        

        //save order to database




    }
}
