using System;
    namespace area_rectangleProgram
{
    class Program
    {
        public static void Main()
        {
            int l, b, area;
            Console.WriteLine("Enter a lenght");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a bredth");
            b = Convert.ToInt32(Console.ReadLine());
            area = l * b;
            Console.WriteLine("Area : " + area);
            Console.ReadKey();
        }
    }
}
