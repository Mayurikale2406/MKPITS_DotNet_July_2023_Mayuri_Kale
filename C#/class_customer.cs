using System;
namespace program
{
    class Customer
    {
        public int customer_code;
        public string customer_name;
    }
    class Program
    {
        static void Main()
        {
            Customer cust = new Customer();
            cust.customer_code = 123;
            cust.customer_name = "mayuri";
            Console.WriteLine("customer code" + cust.customer_code);
            Console.WriteLine("customer name" + cust.customer_name);
            Console.ReadKey();
        }
    }
}