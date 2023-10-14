using System;
namespace rootprogram
{
    class program
    {
        public static void Main()
        {
            int a, b, c , result;
            Console.WriteLine("enter a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a:");
            c = Convert.ToInt32(Console.ReadLine());

            result = (b * b) - 2 * a * c;
            Console.WriteLine("result" + result);
            if (result != 0)
                Console.WriteLine("it is imaginary root");
            else
                Console.WriteLine("it is not imaginary root");
            Console.ReadLine();

        }
    }
}