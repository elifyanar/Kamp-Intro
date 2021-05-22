using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Elif";
            customer.Surname = "Yanar";

            CustomerManager customerManager = new CustomerManager();
            customerManager.addCustomer(customer);
            customerManager.displayCustomer(customer);
            customerManager.deleteCustomer(customer);

        }
    }
}
