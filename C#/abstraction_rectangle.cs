using System;
namespace program
{
     abstract class shape
    {
        public abstract void draw();
    }
    class rectangle: shape
    {
        public override void draw()
        {
            Console.WriteLine("code to draw rectangle");
        }
    }
    class program
    {
        static void Main()
        {
            shape s = new rectangle();
            s.draw();
            Console.ReadKey();
        }
    }
}