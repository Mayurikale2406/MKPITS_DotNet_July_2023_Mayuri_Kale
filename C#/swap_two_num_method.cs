using System;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    class program
    {
        static void display(int num1, int num2)
        {
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("swapping data ");
            Console.WriteLine();
            Console.WriteLine("first number is : " + num1);
            Console.WriteLine("second number is : " + num2);

        }
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            display(num1, num2);
            Console.ReadKey();

        }
    }
}