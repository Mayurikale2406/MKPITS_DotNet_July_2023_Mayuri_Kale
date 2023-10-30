using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr = { 1, 5, 7 };//null=0 
            Array.Clear(arr,0, 3);
            for (int i = 0; i < arr.Length; i++)

            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}