using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter a number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 3 : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num2 > num3)
                Console.WriteLine("number 1 is greater");
            else if (num2 > num3)
                Console.WriteLine("number 2 is greater");
            else
                Console.WriteLine("number 3 is greater");
            Console.ReadKey();


        }
    }
}