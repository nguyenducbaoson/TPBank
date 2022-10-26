using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class CustomerDataAccesslayer : ICustomerDataAccesslayer
    {
        private static List<Customer> customers = new List<Customer>()
        {
            new Customer() {CustomerID=Guid.NewGuid(),customerCode=1,CustomerName="Bao Son",Address="Ha Noi", Landmark="FPT Sofware", City="Ha Noi", Country="Viet Nam", Mobile="012345678", Username="admin", Password="123456"},
            new Customer() {CustomerID=Guid.NewGuid(),customerCode=1,CustomerName="Andeww",Address="Ha Noi", Landmark="FPT Sofware", City="Ninh Binh", Country="Viet Nam", Mobile="012345678", Username="admin", Password="123456"},
            new Customer() {CustomerID=Guid.NewGuid(),customerCode=1,CustomerName="Hoang Minh",Address="Ha Noi", Landmark="FPT Sofware", City="Ha Nam", Country="Viet Nam", Mobile="012345678", Username="admin", Password="123456"},
            new Customer() {CustomerID=Guid.NewGuid(),customerCode=1,CustomerName="Tien Anh",Address="Ha Noi", Landmark="FPT Sofware", City="Ha Noi", Country="Viet Nam", Mobile="012345678", Username="admin", Password="123456"},
        };
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public bool DeleteCustomer(Guid customerID)
        {
            var customer= customers.Where(x => x.CustomerID==customerID).FirstOrDefault();
            if (customer != null) {
                customers.Remove(customer);
                return true;
            }
            return false;
        }

        public List<Customer> GetCustomers()
        {
            return customers.ToList();
        }

        public List<Customer> GetCustomersByCondition(Func<Customer, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomersByUsername(Customer customer)
        {
            return customers.Where(x => x.Username == customer.Username && x.Password == customer.Password).FirstOrDefault();
        }


        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

    }
}
