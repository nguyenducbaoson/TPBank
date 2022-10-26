using Entities;
using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public interface ICustomerBusinessLogicLayer
    {
        ResponseResult Add(Customer customer);
        ResponseResult Update(Customer customer);
        ResponseResult Delete(Customer customer);
        ResponseResult GetCustomersByUsername(Customer customer);
        ResponseResult GetAllCustomer(Customer customer);
    }
}
