using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            long a;
            Console.WriteLine("enter a num : ");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("long : " + a);
            Console.ReadKey();

            ulong a1;
            Console.WriteLine("enter a num : ");
            a1 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("ulong : " + a1);
            Console.ReadKey();
        }
    }
}