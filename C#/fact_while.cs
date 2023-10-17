using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num ;
            int fact=1;

            Console.WriteLine("enter a number");
            num = Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                fact = num * fact;
                num--;

            }
            Console.WriteLine("Result : " + fact);
            Console.ReadKey();

        }
    }
}