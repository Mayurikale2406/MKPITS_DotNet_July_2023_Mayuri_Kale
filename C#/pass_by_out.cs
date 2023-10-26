using System;
namespace program
{
    class program
    {
        static void calculate(int radius,out float area,out float circ)
        {
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;

        }
        static void Main()
        {
            int radius = 5;
            float area, circ;
            calculate(radius, out area, out circ);
            Console.WriteLine("area : " + area);
            Console.WriteLine("circ : " + circ);
            Console.ReadKey();
        }
    }
}