﻿using System;
namespace program
{
    class customer
    {
        int customer_code;
        string customer_name;

        public void getdata( int customer_code,string customer_name)
        {
            this.customer_code = customer_code;
            this.customer_name = customer_name;
        }
        public void displaydata()
        {
            Console.WriteLine("customer code : " + customer_code);
            Console.WriteLine("customer name : " + customer_name);
        }
        class program
        {
            static void Main()
            {
                customer cust = new customer();
                Console.WriteLine("enter customer code & name");
                int cc = Convert.ToInt32(Console.ReadLine());
                string cn = Console.ReadLine();
                cust.getdata(cc, cn);
                cust.displaydata();
                Console.ReadKey();
            }
        }
    }
}