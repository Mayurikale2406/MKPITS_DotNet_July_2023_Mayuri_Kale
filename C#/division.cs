﻿using System;
namespace radiusprogram
{
    class Program
    {
        public static void Main()
        {
            int num1, num2;
            float div;

            Console.WriteLine("Enter a num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            div = (float)num1 / (float)num2;
            Console.WriteLine("result : " + div);
            Console.ReadKey();
        }
    }
}
