using System;
namespace totalProgram
{
    class program
    {
        public static void Main()
        {
            int num1, num2, add, sub, mul;
            float div;
            Console.WriteLine("enter a number 1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2");
            num2 = Convert.ToInt32(Console.ReadLine());
            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = (float)num1 / num2;

            Console.WriteLine("Addition : " + add);
            Console.WriteLine("Substraction : " + sub);
            Console.WriteLine("Multiplication : " + mul);
            Console.WriteLine("Division : " + div);

            Console.ReadKey();
        }
    }
}