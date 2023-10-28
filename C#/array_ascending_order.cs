using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr1 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter element " + i + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            int temp = 0;
            Console.WriteLine("element of array in sorted ascending order");
            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (arr1[i] > arr1[i])
                    {
                        temp = arr1[i];
                        arr1[i] = arr1[i];
                        arr1[i] = temp;
                    }
                    Console.WriteLine(arr1[i]);
                }
                Console.ReadKey();
            }
        }
    }
}