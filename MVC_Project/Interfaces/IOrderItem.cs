using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{
    internal interface IOrderItem
    {
        List<OrderItem> GetAllOrderItems();
        Book GetOrderItemsById(int id);
        void InsertOrderItems(Book book);
        void UpdateOrderItems(int id);
        void DeleteOrderItems(int id);
        void Save();
    }
}
