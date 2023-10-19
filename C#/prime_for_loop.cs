using System;
namespace program
{ 
    class program
    { 
        public static void Main()
            {
                int num;
                Console.WriteLine("enter a number  : ");
                num = Convert.ToInt32(Console.ReadLine());
                int cnt;
                

                for(cnt=1;cnt<num;cnt++)
                {
                    if(num % 2!=0)
                    
                        
                {
                    Console.WriteLine("num is prime ");
                    break;

                }
                else
                    Console.WriteLine("num is not prime");
                }
                Console.ReadKey();
        }
    }
}
