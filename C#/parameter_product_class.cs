using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class Product
    {
        int productId;
        string productName;
        int productPrice;
        int quantity;
        public Product(int productId, string productName, int productPrice, int quantity)
        {
            Console.WriteLine("constructor with paramter called ");
            this.productId = productId;
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity =  quantity;
        }
        public void display()
        {
            Console.WriteLine("product Id : " + productId);
            Console.WriteLine("product Name : " + productName);
            Console.WriteLine("product price : " + productPrice);
            Console.WriteLine("quantity : " + quantity);
        }
    }
    class program
    {
        static void Main()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("enter product Id  : ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product name : ");
            string n1 = Console.ReadLine();
            Console.WriteLine("enter product price : ");
            int p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter product quantity : ");
            int q1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            Product p = new Product(i1, n1, p1, q1);
            Console.WriteLine("-----------------------------------");
            p.display();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            ;

        }
    }
}