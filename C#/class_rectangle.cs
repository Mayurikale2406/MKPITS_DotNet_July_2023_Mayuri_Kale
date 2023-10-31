using System;
namespace program
{
    class Rectangle
    {
        int area, width, height;
         
        public void getdata(int width, int height)
        {
            this.area = area;
            this.width=width;
            this.height = height;
        }
        public void displaydata()
        {
            
            area = width * height;
           
            Console.WriteLine("area of rectangle : " + area);
        }
        class program
        {
            static void Main()
            {
                Rectangle rec = new Rectangle();
                rec.getdata(5, 10);
                rec.displaydata();
                Console.ReadKey();
            }
        }

        
        

    }
}