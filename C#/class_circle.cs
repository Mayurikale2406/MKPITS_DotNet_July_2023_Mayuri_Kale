//Circle Class: Create a Circle class with a property for Radius.
//Implement methods to calculate the circumference and area of the circle. Instantiate the Circle
//class and compute both the circumference and area for a circle with a radius of 7 units.

using System;
namespace program
{
    class circle
    {
        float area_circ,area;
        int radius;
        
        public void getdata(int radius)
        {
            this.area = area;
            this.area_circ = area_circ;
            this.radius = radius;

        }
        public void displaydata()
        {
            area = 3.14f * radius * radius;
            Console.WriteLine("area of circle : " + area);
            area_circ = 2 * 3.14f * radius;
            Console.WriteLine("area of circumference : " + area_circ);
        }

        class program
        {
            static void Main()
            {
                circle c1 = new circle();
                c1.getdata(7);
                c1.displaydata();

                Console.ReadKey();
            }
        }
    }
}