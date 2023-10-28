using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("enter element " + i + ":");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            int j = 0;
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("even number : " + arr2[i]);
            }
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("odd number: " + arr3[i]);
            }
            Console.ReadKey();

        }
    }
}