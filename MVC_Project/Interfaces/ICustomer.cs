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
        Customer GetCustomerById(int id);
        void InsertCustomer(Customer customer);
        void UpdateCustomer(int id);
        void DeleteCustomer(int id);
        List<Customer> GetCustomersByName(string name);
        void Save();
    }
}
