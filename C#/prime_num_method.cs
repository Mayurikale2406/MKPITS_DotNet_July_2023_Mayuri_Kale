using System;
namespace program
{
    class program
    {
        static void prime(int num)

        {
            int cnt = 2;
            int flag = 0;
            while (cnt < num)
            {
                if (num % cnt == 0)
                {
                    flag = 1;
                    break;

                }
                cnt++;
                if (flag == 0)
                {
                    Console.WriteLine("it is prime number");
                }
                else
                {
                    Console.WriteLine("it is not prime number");
                }

            }
        }
         static void Main()
            {
                prime(1);

                Console.ReadKey();
            }

        }
    }
