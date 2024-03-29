using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{
    public interface IOrderItem
    {
        List<OrderItem> GetAllOrderItems();
        OrderItem GetOrderItemsById(int id);
        void InsertOrderItems(OrderItem orderitem);
        void UpdateOrderItems(int id);
        void DeleteOrderItems(int id);
        void Save();
    }
}
