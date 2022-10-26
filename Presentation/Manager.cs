using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class Manager
    {
        private CustomerBusinessLogicLayer customerBLL;
        public Manager(CustomerBusinessLogicLayer customerBLL)
        {
            this.customerBLL = customerBLL;
        }
        public Manager()
        {

        }
        public void Display()
        {

            Console.OutputEncoding = Encoding.UTF8;
            do
            {
                Console.WriteLine("-------------------------Menu ---------------------------");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Get All Existing Customer");
                Console.WriteLine("3. Find Customer");
                Console.WriteLine("4. Update Customer");
                Console.WriteLine("5. Delete Customer");
                Console.WriteLine("0. Exit");
                Console.WriteLine();
                Console.Write("Enter Choice: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (n == 0)
                {
                    break;
                }
                switch (n)
                {
                    case 1:
                        DisPlayAddCustomer();
                        break;
                    case 2:
                        //qLSV.Xuat();
                        break;
                    case 3:

                        //qLSV.TimKiem();
                        break;
                    case 4:

                        //qLSV.XoaSinhVien();
                        break;
                    default:
                        Console.WriteLine("l");
                        break;
                }
            } while (true);
        }

        public void DisPlayAddCustomer()
        {
            try
            {
                Customer customer = new Customer();

                Console.Write("Enter Customer Name: ");
                customer.CustomerName = Console.ReadLine();

                Console.Write("Enter Address: ");
                customer.Address = Console.ReadLine();

                Console.Write("Enter Landmark: ");
                customer.Landmark = Console.ReadLine();

                Console.Write("Enter City: ");
                customer.City = Console.ReadLine();

                Console.Write("Enter Country: ");
                customer.Country = Console.ReadLine();

                Console.Write("Enter Mobile: ");
                customer.Mobile = Console.ReadLine();

                Console.Write("Enter Username: ");
                customer.Username = Console.ReadLine();

                Console.Write("Enter Password: ");
                customer.Password = Console.ReadLine();

                customerBLL.Add(customer);
                Console.WriteLine("Thêm thành công");

                customerBLL.GetAllCustomer(customer);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
