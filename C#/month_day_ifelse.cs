using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num;

            Console.WriteLine("Input Month Number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 1 )

                Console.WriteLine("january"  );


            else if (num == 2)

                Console.WriteLine("february");


            else if (num == 3)

                Console.WriteLine("march");


            else if (num == 4)

                Console.WriteLine("april");


            else if (num == 5)

                Console.WriteLine("may");


            else if (num == 6)

                Console.WriteLine("june");


            else if (num == 7)

                Console.WriteLine("july");

            else if (num == 8)

                Console.WriteLine("Aug");

            else if (num == 9)

                Console.WriteLine("sep");

            else if (num == 10)

                Console.WriteLine("oct");

            else if (num == 11)

                Console.WriteLine("nov");

            else if (num == 12)

                Console.WriteLine("dec");
            else
                Console.WriteLine("invalid number enter a number between 1-12");
            Console.ReadKey();
        }
    }
}

