using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num = 0;
            int num1 = 0;
            int num2 = 1;
            int add;
            do
            {
                Console.WriteLine(num2);

                add = num1 + num2;
                num1 = num2;
                num2 = add;
                num++;
            }
            while (num < 10);
            
                Console.ReadKey();
            

        }
    }
}