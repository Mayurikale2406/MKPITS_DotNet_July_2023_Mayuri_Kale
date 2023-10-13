using System;
namespace oddprogram
{
    class program
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter a num ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >0)

                Console.WriteLine("number is positive");
            else
                Console.WriteLine("number is negative");

            Console.ReadKey();
        }
    }
}
 