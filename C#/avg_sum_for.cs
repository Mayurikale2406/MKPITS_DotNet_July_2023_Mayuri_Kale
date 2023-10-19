using System;
namespace program
{
    class program
    {
        public static void Main()

        {
            int sum=0;
            double avg=0;
           
            for (int cnt=1;cnt<=10;cnt++)
            {
                Console.WriteLine(cnt);
                sum =sum+cnt;
                avg = sum / 10.0;
            }
            Console.WriteLine("sum : " + sum);
            Console.WriteLine("avg : " + avg);
            Console.ReadKey();
        }
    }
}