using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num = 1;
            while (num <= 10)
            {
                if (num % 2 == 0)
                    Console.WriteLine("even no : " + num);
                num++;
            }
            Console.ReadKey();
        }
    }
}