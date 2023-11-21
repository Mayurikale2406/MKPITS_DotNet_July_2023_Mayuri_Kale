using System;
namespace program
{
    class company
    {
        public string name = "TCS";

        public company()
        {
            Console.WriteLine("base class constructor");
            Console.WriteLine("company name : " + name);
        }
    }
    class franchise: company
    {
        public string name = "zudio";
        public franchise()
        {
            Console.WriteLine("derived class constructor");
            Console.WriteLine("franchise name : " + name);
        }
    }
    class program
    {
        public static void Main()
        {
            franchise f = new franchise();
            Console.ReadKey();
        }
    }
}