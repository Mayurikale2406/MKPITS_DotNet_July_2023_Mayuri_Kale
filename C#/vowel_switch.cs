using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            char ch;

            Console.WriteLine("enter a character : ");
            ch = Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("character is vowel");
                    break;
                default:
                    Console.WriteLine("character is consonant");
                    break;
                    Console.ReadKey();

            }
        }
    }
}