using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int num = 1;
            while(num<=10)
            {
                Console.WriteLine(num);
                if(num==7)
                {
                    break;
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}