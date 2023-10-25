using System;
namespace program
{
    class program
    {
        static void table(int num)
        {
            int result = 0;
            for(int cnt=1;cnt<=10;cnt++)
            {
                result = num * cnt;
                Console.WriteLine(num+"*"+cnt+"="+result+"\n");
            }
        }
        static void Main()
        {
            table(8);
            Console.ReadKey();
        }
    }
}