﻿using System;
namespace radiusprogram
{
    class Program
    {
        public static void Main()
        {
            int radius;
            float area, circ;

            Console.WriteLine("Enter a Number");
            radius = Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            Console.WriteLine("area : " + area);
            Console.WriteLine("circumference :" + circ);
            Console.ReadKey();
        }
    }
}