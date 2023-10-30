using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr = { 1, 5, 3 };
            int[] arr1 = new int[3];
            Array.Copy(arr, arr1, 3);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("copy element : " +arr1[i]);
            }
            Console.ReadKey();
        }
    }
}