using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void addCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " is saved.");
        }
        public void displayCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname);
        }
        public void deleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " contact deleted");
        }
    }
}
