using System;
namespace program
{
    class program
    {
        static void acceptarray(int[] arr)
        {
            int sum = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum = sum + arr[i];
               
            }
            Console.WriteLine("sum of array element is : " + sum);
        }
        static void Main()
        {
            int[] num = { 1, 2, 3,4,5,6,7,8,9,10 };
            acceptarray(num);

            int[] num1 = { 11, 22, 33 };
            acceptarray(num1);

            int[] num2 = { 5, 6, 7 };
            acceptarray(num2);

            Console.ReadKey();

        }
        
    }
}