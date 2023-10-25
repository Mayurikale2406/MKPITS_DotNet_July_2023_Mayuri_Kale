using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int num = 1;
            while(true)
            {
                Console.WriteLine(num);
                num++;
                if (num < 10)
                    continue;
                else
                    break;
            }
            Console.ReadKey();
        }
    }
}