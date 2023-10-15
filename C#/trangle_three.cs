using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int t1, t2, t3;
            Console.WriteLine("Enter a t1 :");
            t1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a t2 :");
            t2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a t3 :");
            t3 = Convert.ToInt32(Console.ReadLine());

            if (t1 == t2 && t2 == t3)
                Console.WriteLine("trangle is equilateral ");
            else if (t1 == t2 && t1 == t3 && t2 == t3)
                Console.WriteLine("trangle is isosceles");
            else
            {
                Console.WriteLine("trangle is scalene");
            }
            Console.ReadKey();



        }
    }
}