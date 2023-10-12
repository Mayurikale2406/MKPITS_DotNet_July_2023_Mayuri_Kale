using System;
using System.Runtime.Intrinsics.X86;

namespace byteprogram
{
    class program
    {
        public static void Main()
        {
            byte b;
            Console.WriteLine("enter a number");
            b = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("byte : " + b);
            Console.ReadKey();

            sbyte a;
            Console.WriteLine("enter a number");
            a = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("sbyte : " + a);
        }
    }
}
