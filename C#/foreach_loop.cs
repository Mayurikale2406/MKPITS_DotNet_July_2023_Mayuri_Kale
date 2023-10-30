using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr = { 1, 2, 3 };
            int sum = 0;
            foreach (int num in arr)
            {
                Console.WriteLine(num);
                sum = sum + num;
            }
            Console.WriteLine("sum of array element are " + sum);
            Console.ReadKey();
        }
    }
}