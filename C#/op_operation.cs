using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num1,num2,op,a;
            Console.WriteLine("Enter a first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a operater : ");
            a = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            op = num1 + num2;


            Console.WriteLine("op : " +op);

            Console.ReadKey();





        }
    }
}