using System;
namespace program
{
    class program
    {
        static int[] returnarray()
        {
            int[] num = { 1, 2, 5 };
            return num;
        }
        static void Main()
        {
            int[] res = returnarray();
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}