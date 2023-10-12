using System;
namespace swapnumprogram
{
    class Program
    {
        public static void Main()
        {
            int n1 = 5;
            int n2 = 6;
            int n3;

            n3 = n1;
            n2 = n1;
            n1 = n2;

            
            
           
            Console.WriteLine("swapping data");

            Console.WriteLine("n1 : " + n1);
            Console.WriteLine("n2 : " + n2);

            Console.ReadKey();

        }
    }
}