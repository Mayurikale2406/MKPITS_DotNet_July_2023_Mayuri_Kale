using System;
using System.Runtime.Intrinsics.X86;

namespace tableProgram
{
    class program
    {
        public static void Main()
        {
            int num;
            int count;

            int result;
           
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            for (count = 1; count <= 10; count++)
            {
                result = num * count;
                Console.WriteLine(num + "X" + count + "=" + result);
            }
            Console.ReadLine();


        }
    }
}