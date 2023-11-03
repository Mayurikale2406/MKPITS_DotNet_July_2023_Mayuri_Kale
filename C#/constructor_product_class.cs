using System;
namespace program
{
    class Product
    {
        int productid;
        string productname;
        int price;
        int quantity;

        public Product()
        {
            productid = 123;
            productname = "wow shampoo";
            price = 375;
            quantity = 1;
          
        }
        public void display()
        {
            Console.WriteLine("productid : " + productid);
            Console.WriteLine("product name : " + productname);
            Console.WriteLine("price : " + price);
            Console.WriteLine("quantity : " + quantity);


        }
    }
        class program
    {
        static void Main()
        {
            Product pro = new Product();
            pro.display();
            Console.ReadKey();
        }
    }
}