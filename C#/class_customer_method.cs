using System;
namespace program
{
    internal class Program
    {
        class Customer
        {
            int customer_code;
            string customer_name;


            public void getdata(int cc, string cn)
            {
                customer_code = cc;
                customer_name = cn;
            }
            public void displaydata()
            {
                Console.WriteLine("customer code : " + customer_code);
                Console.WriteLine("customer name" + customer_name);
            }
            static void Main()
            {
                Customer cust = new Customer();
                cust.getdata(123, "mayuri");
                cust.displaydata();
                Console.ReadKey();
            }
        }
    }
}
