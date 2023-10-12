using System;
namespace average
{
    class program
    {
        public static void Main()
        {
            int num1, num2, num3, num4, add;
            Console.WriteLine("Enter a number 1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 3 : ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number 4 : ");
            num4 = Convert.ToInt32(Console.ReadLine());
            add =( num1 + num2 + num3 + num4 )/ (4);
            Console.WriteLine("Total Average : " + add);
            Console.ReadKey();
        }
    }
}