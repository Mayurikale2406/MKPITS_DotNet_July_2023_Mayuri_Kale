using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("Enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine(" jan have 31 days ");
                    break;
                case 2:
                    Console.WriteLine(" feb have 28/29 days");
                    break;
                case 3:
                    Console.WriteLine(" march have 31 days");
                    break;
                case 4:
                    Console.WriteLine(" april have 30 days");
                    break;
                case 5:
                    Console.WriteLine("may have 31 days ");
                    break;
                case 6:
                    Console.WriteLine(" june have 30 days");
                    break;
                case 7:
                    Console.WriteLine("july have 31 days");
                    break;
                case 8:
                    Console.WriteLine(" aug have 30 days ");
                    break;
                
                default:
                    Console.WriteLine("Invalid number enter num between 1-10");
                    break;
            }

            Console.ReadKey();







        }
    }
}