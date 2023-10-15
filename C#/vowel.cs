using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            string ch;
            Console.WriteLine("enter a character :");
            ch = Console.ReadLine();

            if (ch == "a" ||ch == "e" ||ch== "i" || ch =="o" ||ch == "u")
                Console.WriteLine("character are vowels");
            else
                Console.WriteLine("character are consonent");
            Console.ReadKey();

        }
    }
}