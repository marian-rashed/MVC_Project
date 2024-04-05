using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Project.Interfaces
{
    public interface ICustomer
    {
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(string id);
        void InsertCustomer(Customer customer);

       

        void UpdateCustomer(string id);
        void DeleteCustomer(string id);
      List<Customer> GetCustomersByName(string name);

        void Save();
    }
}
