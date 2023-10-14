using System;
namespace oddprogram
{
    class program
    {
        public static void Main()
        {
            int age;
            Console.WriteLine("enter a age : ");
            age = Convert.ToInt32(Console.ReadLine());
            if (age >=18)
                Console.WriteLine("eligible for vote");
            else
                Console.WriteLine("not eligible for vote");

            Console.ReadKey();

        }
    }
}