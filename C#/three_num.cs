using System;
namespace three_number
{
    class program
    {
        public static void Main()
        {
            int x,y,z, result;

            Console.WriteLine("enter first num : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second num : ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third num : ");
            z = Convert.ToInt32(Console.ReadLine());

            result = (x + y) * (z);
            Console.WriteLine("Total :  " + result);

            result = (x) * (y) + (y) * (z);
            Console.WriteLine(" Total : " + result);

            Console.ReadKey();


        }
    }
}