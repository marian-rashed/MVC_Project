using MVC_Project.Interfaces;

namespace MVC_Project.Repository
{
    public class OrderRepository:IOrder
    {
        BookStoreContext bookStoreContext;
        public OrderRepository(BookStoreContext _bookStoreContext)
        {
            bookStoreContext = _bookStoreContext;
        }

        public void DeleteOrder(int id)
        {
            Order order = bookStoreContext.Orders.FirstOrDefault(o => o.OrderId == id);
            bookStoreContext.Orders.Remove(order);
        }

        public List<Order> GetAllOrders()
        {
            List<Order> orders = bookStoreContext.Orders.ToList();
            return orders;
        }

        public Order GetOrderById(int id)
        {
            Order order = bookStoreContext.Orders.FirstOrDefault(o => o.OrderId == id);
            return order;
        }

        public void InsertOrder(Order order)
        {
            bookStoreContext.Orders.Add(order);
        }

        public void Save()
        {
            bookStoreContext.SaveChanges();
        }

        public void UpdateOrder(int id)
        {
            Order order = bookStoreContext.Orders.FirstOrDefault(o => o.OrderId == id);
            bookStoreContext.Orders.Update(order);
        }
    }
}
