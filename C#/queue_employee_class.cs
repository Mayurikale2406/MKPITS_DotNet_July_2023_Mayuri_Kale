//create a queue collection of customer class(custid, custname, email, mobno)
using System;
using System.Collections;
namespace program
{
    class Customer
    {
        public int custid;
        public string custname;
        public string email;
        public int mobno;

        public Customer(int custid,string custname,string email,int mobno)
        {
            this.custid = custid;
            this.custname = custname;
            this.email = email;
            this.mobno = mobno;

        }
        class program
        {
            static void Main()
            {
                Customer c1 = new Customer(11, "mayuri", "mayuri@gmail.com", 1234);
                Customer c2 = new Customer(12, "vrushali", "vrushali@gmail.com", 2345);
                Customer c3 = new Customer(13, "sayali", "sayali@gmail.com", 5678);
                Customer c4 = new Customer(14, "priya", "priya@gmail.com", 7890);


                Queue q = new Queue();
                Console.WriteLine("After add");
                q.Enqueue(c1);
                q.Enqueue(c2);
                q.Enqueue(c3);
                q.Enqueue(c4);

                foreach (Customer e in q)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Customer Id : " + e.custid);
                    Console.WriteLine("Customer Name : " + e.custname);
                    Console.WriteLine("Customer Salary : " + e.email);
                    Console.WriteLine("Employee designation : " + e.mobno);
                    Console.WriteLine("-----------------------------");


                }
                Console.WriteLine("After Dequeue");
                
                q.Dequeue();

                foreach (Customer e in q)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Customer Id : " + e.custid);
                    Console.WriteLine("Customer Name : " + e.custname);
                    Console.WriteLine("Customer Salary : " + e.email);
                    Console.WriteLine("Employee designation : " + e.mobno);
                    Console.WriteLine("--------------------------------");

                }






            }

        }

    }
}