using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main()
        {
            int num = 0;
            int num1 = 0, num2 = 1;
            int add;

            while (num < 10)
            {
                Console.WriteLine(num2);

                add = num1 + num2;
                num1 = num2;
                num2 = add;

                num++;
            }

            Console.ReadKey();
        }
    }
}
