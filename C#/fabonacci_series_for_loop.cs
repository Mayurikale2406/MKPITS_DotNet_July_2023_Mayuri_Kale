using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        public static void Main()
        {

            int num1 = 0;
            int num2 = 1;
            int add;

            for (int num = 0; num < 20; num++)
            {
                Console.WriteLine(num2);
                add = num1 + num2;
                num1 = num2;
                num2 = add;

            }
            Console.ReadKey();
        }
    }
}