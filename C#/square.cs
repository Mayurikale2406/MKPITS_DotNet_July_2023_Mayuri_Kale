﻿using System;
namespace squareProgram
  {
     class program
{
    public static void Main()
    {
        int num, square;
        Console.WriteLine("enter a number");
        num = Convert.ToInt32(Console.ReadLine());
        square = num * num;
        Console.WriteLine("square =" + square);
        Console.ReadKey();

    }

}
    
    }