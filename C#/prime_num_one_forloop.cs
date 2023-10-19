using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class program
    {
        public static void Main()
        {
            Console.WriteLine("prime no : 2 ");
            int num = 3;
            int cnt = 2;
            int flag = 0;
            for (num = 3; num <= 20; num++)
            {
                flag = 0;
                cnt = 2;
                {
                    while (cnt < num)
                    {
                        if (num % cnt == 0)
                        {
                            flag = 1;
                            break;
                        }
                        cnt++;
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine("prime no : {0}", num);
                    }
                }
            }

        }
    }
}