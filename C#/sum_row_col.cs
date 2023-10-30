using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int sum = 0;
            
            int[,] arr1 = new int[2,2];
            Console.WriteLine("enter input element");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("element - {0},{1} : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int rowsum = 0;
            int colsum = 0;
            Console.WriteLine();
            Console.WriteLine("the sum of row and col of matrix");
            for(int i=0;i<2;i++)
            {
                rowsum = 0;
                for(int j=0;j<2;j++)
                {
                    rowsum = rowsum + arr1[ i,j];
                }
                Console.WriteLine( rowsum);
            }
            Console.WriteLine("the sum of col of matrix ");
            for(int j=0;j<2;j++)
            {
                colsum = 0;
                for(int i=0;i<2;i++)
                {
                    colsum = colsum + arr1[i, j];
                }
                Console.WriteLine( colsum);
            }
            Console.ReadKey();
        }
    }
}