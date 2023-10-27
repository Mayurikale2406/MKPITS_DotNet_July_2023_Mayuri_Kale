using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[,] arr1 = { { 1, 2 }, { 3, 4 } };
            int[,] arr2 = { { 5, 6 }, { 7, 8 } };
            int[,] arr3 = new int[2, 2];
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    arr3[row, col] = arr1[row, col] * arr2[row, col];

                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(arr3[row, col] + "\t");
                }
                Console.WriteLine();
                
            }
            Console.ReadKey();
        }
    }
}