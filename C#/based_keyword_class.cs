using System;
namespace program
{
    class Animal
    {
        public string color = "white";
    }
    class Dog : Animal
    {
        public string color = "red";
        public void displaycolor()
        {
            Console.WriteLine("dog color : " + color);
            Console.WriteLine("animal color : " + base.color);
        }
    }
    class program
    {
        public static void Main()
        {
            Dog d1 = new Dog();
            d1.displaycolor();
            Console.ReadKey();
        }
    }
}