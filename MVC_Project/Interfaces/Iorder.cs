using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{
    public interface IOrder
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        void InsertOrder(Order order);
        void UpdateOrder(int id);
        void DeleteOrder(int id);
        //List<Customer> GetCustomersOrder(int orderid);
        void Save();
    }
}
