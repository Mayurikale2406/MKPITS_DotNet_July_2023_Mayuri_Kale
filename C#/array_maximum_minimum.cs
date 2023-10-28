using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter element" + i + ":");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0], min = arr[0];
            for (int i = 0; i < 3; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("maximum element is : " + max);
            Console.WriteLine("minimum element is : " + min);
            Console.ReadKey();
        }
    }
}
               
            
            

            