using System;
namespace ifprogram
{
    class program
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter a number1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine("Number 1 is greater");
            else
                Console.WriteLine("Number 2 is greater");
            Console.ReadLine();



        }
    }
}