using System;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    public class calculator
    {
        public double result { get; set; }
        public void Add(double num)
        {
            result += num;
        }
        public void Sub(double num)
        {
            result -= num;
        }
        public void Mul(double num)
        {
            result *= num;
        }
        public void Div(double num)
        {
            if(num!=0)
            {
                result /= num;
            }
            else
            {
                Console.WriteLine("Error : cannot divide by zero");
            }
        }
        public void clear()
        {
            result = 0;
        }
    }
    class program
    {
        static void Main()
        {
            calculator cal = new calculator();
            cal.Add(5);
            Console.WriteLine("Addition : " + cal.result);

            cal.Sub(2);
            Console.WriteLine("Substraction: " + cal.result);

            cal.Mul(3);
            Console.WriteLine("Multiplication : " + cal.result);

            cal.Div(2);
            Console.WriteLine("Division : " + cal.result);

            cal.clear();
            Console.WriteLine("Result after clearing : " + cal.result);

            Console.ReadLine();
        }
    }
}