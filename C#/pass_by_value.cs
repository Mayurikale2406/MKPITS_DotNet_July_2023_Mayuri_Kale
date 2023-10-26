using System;
namespace program
{
    class program
    {
        static void display(int num)
        {
            num = 20;
            Console.WriteLine("num inside method " + num);

        }
        static void Main()
        {
            int num = 10;
            display(num);
            Console.WriteLine("num after passing inside main" + num);
            Console.ReadKey();

        }
    }
}