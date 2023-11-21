using System;
namespace program
{
   interface shape
    {
        void draw();

    }
    class rectangle:shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of rectangle class");
        }
    }
    class circle:shape
    {
        public void draw()
        {
            Console.WriteLine("draw method of circle class");
        }
    }
    class program
    {
        static void Main()
        {
            shape s = new rectangle();
            s.draw();
            shape s1 = new circle();
            s1.draw();
            Console.ReadKey();
        }
    }
}