using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] arr = new int [3];
            int num;
            
            Console.WriteLine("input the number of element in array: ");
            num = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<3;i++)
            {
                Console.WriteLine("element - [{i}]" );
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("stored first element are : ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(+ arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("copy stored element are : ");
            for (int i = 0;  i < 3;i++)
            {
            Console.Write(+ arr[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}