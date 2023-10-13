using System;
namespace oddprogram
{
    class program
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine("given num is even");
            else
                Console.WriteLine("given num is odd");

            Console.ReadKey();
        }
    }
}