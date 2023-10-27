using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter number : ");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("the value store into the array are:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine("the value stores into the array in reverse are: ");
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
