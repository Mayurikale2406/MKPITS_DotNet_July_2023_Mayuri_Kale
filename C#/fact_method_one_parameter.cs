using System;
namespace program
{
    class program
    {
      
        
            static void factorial(int num)
            {
                int fact = 1;
                while(num>0)
                {
                    fact = fact * num;
                    num--;
                }
                Console.WriteLine("fact : " + fact);
            }
            static void Main()
            {
                factorial(5);
            }
        }
    }
