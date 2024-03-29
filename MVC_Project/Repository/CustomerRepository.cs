using MVC_Project.Interfaces;

namespace MVC_Project.Repository
{
    public class CustomerRepository :ICustomer
    {
        BookStoreContext bookStoreContext;
        public CustomerRepository(BookStoreContext _bookStoreContext)
        {
            bookStoreContext = _bookStoreContext;
        }

        public void DeleteCustomer(int id)
        {
            Customer customer = bookStoreContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            bookStoreContext.Customers.Remove(customer);
        }

        public void Save()
        {
            bookStoreContext.SaveChanges();
        }

        public void UpdateCustomer(int id)
        {
            Customer customer = bookStoreContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            bookStoreContext.Customers.Update(customer);
        }

        List<Customer> ICustomer.GetAllCustomers()
        {
            List<Customer> customers = bookStoreContext.Customers.ToList();
            return customers;
        }

        Customer ICustomer.GetCustomerById(int id)
        {
            Customer customer = bookStoreContext.Customers.FirstOrDefault(c => c.CustomerId == id);
            return customer;
        }

        void ICustomer.InsertCustomer(Customer customer)
        {
            bookStoreContext.Customers.Add(customer);
        }


    }
}
