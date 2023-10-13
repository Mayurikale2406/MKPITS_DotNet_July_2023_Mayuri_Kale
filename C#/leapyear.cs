using System;
namespace oddprogram
{
    class program
    {
        public static void Main()
        {
            int year;
           
            Console.WriteLine("enter a year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year%4==0)

                Console.WriteLine("it is leap year");
            else
                Console.WriteLine("it is not year");
            Console.ReadKey();
        }
    }
}
