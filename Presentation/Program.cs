// See https://aka.ms/new-console-template for more information

using Entities;
using Presentation;
using System.Text;

namespace BusinessLogicLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Display();
        }
    }
}