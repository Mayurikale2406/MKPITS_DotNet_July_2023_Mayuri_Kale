using System;
using System.Diagnostics.CodeAnalysis;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num,cnt=1,result=0;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            

            while(cnt<=num)
            {
                
                result = cnt*cnt*cnt;
                Console.WriteLine("Number is : {0} and cube of the {1} is {2}" ,cnt,cnt, result);
                cnt++;




            }
            

            Console.ReadKey();
        }
    }
}