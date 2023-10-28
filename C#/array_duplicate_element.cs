using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] num = new int[5];
            
            int count = 0;

            Console.WriteLine("input the number of element in array: ");

            for (int i = 0; i < 5; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("element -{0}={1}", i, num[i]);

            }


            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (num[i] == num[j])
                    {
                        count++;
                        break;
                    }

                }
            }
                Console.WriteLine("it is duplicate number " + count);
                Console.ReadKey();
            }
        }
    }
