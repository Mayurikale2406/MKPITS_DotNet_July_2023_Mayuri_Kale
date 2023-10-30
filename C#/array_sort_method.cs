using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr = { 1, 7, 2,5 };
            Array.Sort(arr);
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}