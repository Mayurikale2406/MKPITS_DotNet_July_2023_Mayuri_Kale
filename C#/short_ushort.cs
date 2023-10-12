using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            short s;
            Console.WriteLine("enter a number");
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Short : " + s);
            Console.ReadKey();

            ushort s1;
            Console.WriteLine("enter a number");
            s1 = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Short : " + s1);
            Console.ReadKey();
        }
    }
}
