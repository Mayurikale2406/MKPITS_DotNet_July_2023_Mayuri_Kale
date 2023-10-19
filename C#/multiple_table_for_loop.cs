using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int n;
            int result = 0;
            Console.WriteLine("enter a limit : ");
            n = Convert.ToInt32(Console.ReadLine());
            int num;
            int cnt;
            for(num=1;num<10;num++)
            {
                for(cnt=1;cnt<=n;cnt++)
                {
                    result = num * cnt;
                    Console.Write("{0}*{1}={2}", cnt, num, result);
                    Console.Write("\t");
                    
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}