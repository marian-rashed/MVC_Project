using MVC_Project.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{

    public interface IOrder

    {
        List<OrderWithCustomerAndOrderListVM> GetAllOrdersWithCustomerAndOrderList();
        OrderWithCustomerAndOrderListVM GetOrderByIdWithCustomerAndOrderList(int id);
        void InsertOrder(OrderWithCustomerAndOrderListVM orderVM);
        void UpdateOrder(int id);
        void DeleteOrder(int id);
        void Save();

        List<OrderWithCustomerAndOrderListVM> GetOrdersByCustomerName(string customername);
        List<OrderWithCustomerAndOrderListVM> GetOrderByCustomerId(string customerid);
        
    }
}
