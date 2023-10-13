using System;
namespace equal
{
    class program
    {
        public static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
                Console.WriteLine("number are equal ");
            else
                Console.WriteLine("number are not equal");

            Console.ReadKey();

        }
    }
}