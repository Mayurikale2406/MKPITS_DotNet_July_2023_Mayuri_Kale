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
            Console.WriteLine();
            int cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                cnt = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])
                        {
                            cnt++;
                            break;
                        }
                    }
                }
                if (cnt == 0)
                {
                    Console.WriteLine("unique number is :" + arr[i]);
                    
                }
            }
            Console.ReadKey();
        }
    }
}