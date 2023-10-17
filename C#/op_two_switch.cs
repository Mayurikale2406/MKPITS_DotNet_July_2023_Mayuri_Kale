using System;
using System.Data.SqlTypes;
using System.Drawing;

namespace program
{
    class program
    {
        public static void Main()
        {
            int num1, num2, add, sub, mul, choice;
            float div;

            Console.WriteLine("choice 1 for addition ");
            Console.WriteLine("choice 2 for substraction ");
            Console.WriteLine("choice 3 for multiplication ");
            Console.WriteLine("choice 4 for division ");

            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter a first num : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a second num : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    add = num1 + num2;
                    Console.WriteLine("result : " + add);
                    break;

                case 2:
                    sub = num1 - num2;
                    Console.WriteLine("result : " + sub);
                    break;
                case 3:
                    mul = num1 * num2;
                    Console.WriteLine("result : " + mul);
                    break;
                case 4:
                    div =(float) num1 / num2;
                    Console.WriteLine("result : " + div);
                    break;
            }
            Console.ReadKey();






        }
    }

}
            