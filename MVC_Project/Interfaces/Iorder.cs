using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{
    public interface Iorder
    {
        List<Order> GetAllOrders();
        Order GetOrderById(int id);
        void InsertOrder(Book book);
        void UpdateOrder(int id);
        void DeleteOrder(int id);
        //List<Customer> GetCustomersOrder(int orderid);
        void Save();
    }
}
