using System;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    class program
    {
        static void display(int num1 ,int num2)
        {
            int sum;
            sum = num1 + num2;
            Console.WriteLine("sum of two number : " + sum);
        }
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("enter a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter another number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            display(num1, num2);
        }
        
    }
}