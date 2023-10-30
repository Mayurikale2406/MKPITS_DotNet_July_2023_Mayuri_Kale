using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int r = 0;
            int c = 0;
            int[,] arr1 = { { 1, 2 }, { 3, 4 } };
            int[,] arr2 = { { 5, 6 }, { 7, 8 } };
            int[,] arr3 = new int[2, 2];
            Console.WriteLine("input element");
            for (r = 0; r < 2; r++)
            {
                for (c = 0; c < 2; c++)
                {
                    Console.WriteLine("element-{0},{1}: ", r, c);
                    arr1[r, c] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("input element in the matrix 2");
            for (r = 0; r < 2; r++)
            {
                for (c = 0; c < 2; c++)
                {
                    Console.WriteLine("element - [{0},{1}] : ", r, c);
                    arr2[r, c] = Convert.ToInt32(Console.ReadLine());
                }

            }
            Console.WriteLine("\n matrix 1 is :  \n");
            for (r = 0; r < 2; r++)
            {
                for (c = 0; c < 2; c++)
                {
                    Console.WriteLine("{0}\t", arr1[r, c]);
                }
                Console.WriteLine("\n matrix 2 is : \n");
                for (r = 0; r < 2; r++)
                {
                    for (c = 0; c < 2; c++)
                    {
                        Console.WriteLine("{0}\t", arr2[r, c]);
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("addition of 2 matrix ");
                for (r = 0; r < 2; r++)
                {
                    Console.WriteLine("\n");
                    for (c = 0; c < 2; c++)
                    {
                        arr3[r, c] = arr1[r, c] * arr2[r, c];
                    }
                }
                for (r = 0; r < 2; r++)
                {
                    for (c = 0; c < 2; c++)
                    {
                        Console.Write(arr3[r, c] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.ReadKey();
            }
        }
    }
}