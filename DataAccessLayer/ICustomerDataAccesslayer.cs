using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface ICustomerDataAccesslayer
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomersByCondition(Func<Customer, bool> predicate);
        void AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Guid customerID);
        Customer GetCustomersByUsername(Customer customer);
    }
}
