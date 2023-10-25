using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static int calculate(int num1, int num2, char op) //method with 3 integer parameter
        {
            int result = 0;
            if (op == '+')
                result = num1 + num2;
            else if (op == '-')
                result = num1 - num2;
            else if (op == '*')
                result = num1 * num2;
            else
                Console.WriteLine("invalid operater");
            return result;

        }
        static void Main()
        {
            int number1, number2;
            char ope;
            Console.WriteLine("enter number 1");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number 2");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter op + - *");
            ope = Convert.ToChar(Console.ReadLine());
            int result = calculate(number1, number2, ope);
            Console.WriteLine("result : " + result);
            Console.ReadKey();
        }
    }
}