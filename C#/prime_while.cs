using System;
using System.ComponentModel.Design;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter num");
            num = Convert.ToInt32(Console.ReadLine());
            int cnt = 2;
            int flag = 0;
            while(cnt<num)
            {
                if(num%cnt==0)
                {
                    flag = 1;
                    break;
                }
                cnt++;

            }
            if (flag == 0)
            {
                Console.WriteLine("num is prime");
            }
            else
            {
                Console.WriteLine("num is not prime");

            }
            Console.ReadKey();
        }
    }
}