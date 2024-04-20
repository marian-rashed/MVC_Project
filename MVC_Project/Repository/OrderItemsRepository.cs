using MVC_Project.Interfaces;

namespace MVC_Project.Repository
{
    public class OrderItemsRepository : IOrderItem
    {
        BookStoreContext bookStoreContext;
        public OrderItemsRepository(BookStoreContext _bookStoreContext)
        {
            bookStoreContext = _bookStoreContext;
        }
        public List<OrderItem> GetAllOrderItems()
        {
            List<OrderItem> orderItems = bookStoreContext.OrderItems.ToList();
            return orderItems;
        }
        public OrderItem GetOrderItemsById(int id)
        {
            OrderItem orderItem = bookStoreContext.OrderItems.FirstOrDefault(oi => oi.OrderItemId == id);
            return orderItem;
        }
        public void InsertOrderItems(OrderItem orderItem)
        {
            bookStoreContext.OrderItems.Add(orderItem);
        }

		public void UpdateOrderItems(int id)
        {
            OrderItem orderItem = bookStoreContext.OrderItems.FirstOrDefault(oi => oi.OrderItemId == id);
            bookStoreContext.OrderItems.Update(orderItem);
        }
        public void DeleteOrderItems(int id)
        {
            OrderItem orderItem = bookStoreContext.OrderItems.FirstOrDefault(oi => oi.OrderItemId == id);
            bookStoreContext.OrderItems.Remove(orderItem);
        }
        public void Save()
        {
            bookStoreContext.SaveChanges();
        }
    }
}
