//Product Class: Define a Product class with properties for Name, Price, and StockQuantity.
//Create an instance of the Product class and simulate a purchase where you reduce the stock quantity by a certain amount.
//Display the updated stock quantity.

using System;
namespace program
{
    class Product
    {
        public string product_name { get; set; }
        public int product_price { get; set; }
        public int stock_quantity { get; set; }

        public void getdata(string name,int price,int quantity)
        {
            this.product_name = product_name;
            this.product_price = product_price;
            this.stock_quantity = stock_quantity;
        }

        public void display()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("product name : " + product_name);
            Console.WriteLine("product price : " + product_price);
            Console.WriteLine("stock quantity : " + stock_quantity);

        }
       
    }
    class program
    {
        static void Main()
        {
            Product p = new Product();
            string name;
            int item, price;
            int total=0;
            int stock = 20;

            

            Console.WriteLine("enter product name: ");
            name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter product price: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter stock quantity: ");
            item = Convert.ToInt32(Console.ReadLine());

                int remainstock = item-stock;
                total = price * item;

                p.getdata(name, price, item);
                Console.WriteLine("remaining stock : " + remainstock);
                Console.WriteLine("price : " + total);
                p.display();

            Console.ReadKey();
          



            
        }
    }
}
