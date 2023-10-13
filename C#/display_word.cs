using System;
namespace displayprogram
{
    class program
    {
        public static void Main()
        {
            int num;

            Console.WriteLine("enter a num : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1)
                Console.WriteLine("one");
            else if (num == 2)
                Console.WriteLine("two");
            else if (num == 3)
                Console.WriteLine("three");
            else
                Console.WriteLine("invalid number");

            Console.ReadKey();
        }
    }
}