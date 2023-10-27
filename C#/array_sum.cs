using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] num= new int[] { 2, 5, 8 };
            int sum = 0;

            for(int cnt=0;cnt<3;cnt++)
            {
                sum = sum + num[cnt];
            }
            Console.WriteLine("sum : " + sum);
            Console.ReadKey();
        }
        
    }
}