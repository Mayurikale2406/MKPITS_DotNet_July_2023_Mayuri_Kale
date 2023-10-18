using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num = 1;
            int sum = 0;
            do
            {
                if (num % 2 == 1)
                {
                    Console.WriteLine("odd no " + num);
                    sum += num;
                }
                num++;
            }
            while (num <= 20);
            {
                Console.WriteLine("sum : " + sum);
                Console.ReadKey();
            }
        }
    }
}
