using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[,] num = { { 1, 2 }, { 3, 4 } };
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(num[row, col] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}