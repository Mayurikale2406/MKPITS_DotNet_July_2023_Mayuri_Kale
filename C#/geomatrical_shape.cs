using System;


namespace program
{
    class program
    {
        public static void Main()
        {
            int choice,num1,num2, r,sqr,l,b,h,rectangle;
            float area,trangle;
            Console.WriteLine("enter a input your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
               
                Console.WriteLine("enter a r : ");
                r = Convert.ToInt32(Console.ReadLine());
                area = 3.14f * r * r;
                Console.WriteLine("result : " + area);
            }

            else if (choice == 2)
            {

                Console.WriteLine("enter a number  : ");
                num1 = Convert.ToInt32(Console.ReadLine());

                sqr = num1 * num1;
                Console.WriteLine("result : " + sqr);
            }

            else if (choice == 3)
            {
                Console.WriteLine(" enter lenght :  ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter breadth :  ");
                b = Convert.ToInt32(Console.ReadLine());

                rectangle = l * b;

                Console.WriteLine("result : " + rectangle);
            }
            else if (choice == 4)
            {
                Console.WriteLine(" enter base:  ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" enter height :  ");
                h = Convert.ToInt32(Console.ReadLine());

                trangle = 0.5f * b * h;

                Console.WriteLine("result : " + trangle);
            }




            Console.ReadKey();

             
        }
    }
}