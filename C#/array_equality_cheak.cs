using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int flag=0;
            int[,] arr1 = new int[2, 2];
            int[,] arr2 = new int[2, 2];
            Console.WriteLine("enter first matrices");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("element - {0},{1} : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            
            Console.WriteLine("enter second matrices");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("element - {0},{1} : ", i, j);
                    arr2
                        [i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int i=0;i<2; i++)
            {
                for(int j=0;j<2;j++)
                {
                    if (arr1[i, j] == arr2[i, j]) 
                    {
                        flag = 1;
                        break;

                    }
                }
                
            }
            if(flag==1)
            {
                Console.WriteLine("matrix are equal");
            }
            else
            {
                Console.WriteLine("matrix are not equal");
            }
            Console.ReadKey();
        }
    }
}