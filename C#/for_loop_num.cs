using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        public static void Main()
        {
            int cnt;
            for(cnt=1;cnt<=10;cnt++)
            {
                Console.WriteLine(cnt);
            }
            Console.ReadKey();
        }
    }
}