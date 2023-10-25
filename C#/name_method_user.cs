using System;
namespace program
{
    class program
    {
        static void display(string name)
        {
            Console.WriteLine("welcome" +" "+ name + "!");
            Console.WriteLine("have a nice day");
        }
        static void Main()
        {
            string name;
            Console.WriteLine("enter a name ");
            name = (Console.ReadLine());

            display(name);
            Console.ReadKey();
        }
    }
}