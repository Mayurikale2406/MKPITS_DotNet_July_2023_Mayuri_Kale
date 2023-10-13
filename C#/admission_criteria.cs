using System;
namespace admissionprogram
{
    class program
    {
        public static void Main()
        {
            int sub1, sub2, sub3;
            int total;

            Console.WriteLine("enter a sub 1 mark : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a sub 2 mark : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a sub 3 mark : ");
            sub3 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3;

            if (total >= 180)
                Console.WriteLine("they are eligible");
            else
                Console.WriteLine("they are not eligible");

            Console.ReadKey();





        }
    }
}