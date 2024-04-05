namespace MVC_Project.ViewModel
{
    public class OrderWithCustomerAndOrderListVM
    {
        public OrderWithCustomerAndOrderListVM()
        {
            Customer = new Customer();
            OrderItems = new List<OrderItem>();
        }

        public int? OrderId { get; set; }
        public Customer? Customer { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
    }
}
