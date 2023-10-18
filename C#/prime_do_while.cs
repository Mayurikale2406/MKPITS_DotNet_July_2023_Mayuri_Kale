using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num, cnt = 2, flag = 0;
            Console.WriteLine("enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (num % 2 == 0)
                {
                    flag = 1;
                    break;

                }
                cnt++;
            }
            while (cnt < num);
            if(flag==0)
            {
                Console.WriteLine("number is prime");

            }
            else
            {
                Console.WriteLine("number is not prime ");
            }
            Console.ReadKey();
        }
    }
}