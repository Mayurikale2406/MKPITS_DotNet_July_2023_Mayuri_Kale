using System;
namespace oddprogram
{
    class program
    {
        public static void Main()
        {
            int height;
            Console.WriteLine("enter a height : ");
            height = Convert.ToInt32(Console.ReadLine());
            if (height <= 135)
                Console.WriteLine("category is dwarf");
            else
                Console.WriteLine("category is taller");

            Console.ReadKey();
        }
    }
}