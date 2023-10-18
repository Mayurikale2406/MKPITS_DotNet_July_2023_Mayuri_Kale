using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int sum = 0;
            int num =1;
            double avg = 0;
           

            do
            {
                Console.WriteLine(num);
                sum += num;
                avg = sum / 10.0;
                num++;
            }
            while (num <= 10 );
            {
                Console.WriteLine("result " + sum);
                Console.WriteLine("average : " + avg);
                Console.ReadKey();
            }
        }
    }
}