using DataAccessLayer;
using Entities;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CustomerBusinessLogicLayer : ICustomerBusinessLogicLayer
    {
        private ICustomerDataAccesslayer customerDAL;
        public CustomerBusinessLogicLayer(ICustomerDataAccesslayer customerDAL)
        {
            this.customerDAL = customerDAL;
        }

        public ResponseResult Add(Customer customer)
        {
            try
            {
                if (customer.CustomerName.Length < 1)
                {
                    return new ResponseResult("Customer Name is valid");
                }
                customerDAL.AddCustomer(customer);
                return new ResponseResult();
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex.Message);
            }
        }
        public ResponseResult Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void GetAllCustomer(Customer customer)
        {
            DisplayCustomers(customerDAL.GetCustomers());
               
        }

        public ResponseResult GetCustomersByUsername(Customer customer)
        {
            try
            {
                var cus = customerDAL.GetCustomersByUsername(customer);
                if (cus == null)
                {
                    Console.WriteLine("sai username hoac password");
                }
                else
                {
                    ResponseResult.IsLogin=true;
                }
                return new ResponseResult();
            }
            catch (Exception ex)
            {
                return new ResponseResult(ex.Message);
            }
        }

        public ResponseResult Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DisplayCustomers(List<Customer> customers)
        {
            Console.WriteLine("{0,-15}{1,-25}{2,-15}{3,-15}{4,-15}{5,-15}{6,-15}{7,-15}{8,-15}", "CustomerCode", "CustomerName", "Address", "LandMark", "City", "Country", "Mobile", "UserName", "Password");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        ResponseResult ICustomerBusinessLogicLayer.GetAllCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
