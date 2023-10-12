using System;
namespace mulProgram
{
    class program
    {
        public static void Main()
        {
            int num1;
            int num2;
            int num3;
            int mul;

            Console.WriteLine("enter a number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 3");
            num3 = Convert.ToInt32(Console.ReadLine());
            mul = num1 * num2 * num3;
            Console.WriteLine("Total : " + mul);
            Console.ReadKey();
        }
    }
}