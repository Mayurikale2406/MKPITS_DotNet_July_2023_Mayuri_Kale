using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[,] arr1 = new int[2, 2];
            int sum = 0;
            Console.WriteLine("enter matrix element");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("element-[{i}][{j}] :");
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("matrix is");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("\t"+arr1[i, j]);
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < 2; i++)
            {
                
                {
                    sum = sum + arr1[i, i];
                }
            }
            Console.WriteLine("diagonal matrix is : " + sum);
        }
    }
}
