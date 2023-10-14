using System;


namespace program
{
    class program
    {
        public static void Main()
        {
            int choice, num1,num2,add,sub,mul;
            float div;
            Console.WriteLine("enter a input your choice (enter number): ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                
                Console.WriteLine("enter a num1 : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a num1 : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                add = num1+num2;
                Console.WriteLine("result : " + add);
            }

            else if (choice == 2)
            {
                Console.WriteLine("enter a num1 : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a num1 : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                sub = num1 - num2;

                Console.WriteLine("result : " + sub);

            }

            else if (choice == 3)
            {
                Console.WriteLine("enter a num1 : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter a num1 : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                mul = num1 * num2;

                Console.WriteLine("result : " + mul);
            }
            else if (choice == 4)
            {
                Console.WriteLine("enter a num1 : ");
                num1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("enter a num1 : ");
                num2 = Convert.ToSingle(Console.ReadLine());
                div = num1 / num2;

                Console.WriteLine("result : " + div);
            }




            Console.ReadKey();


        }
    }
}