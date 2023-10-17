using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            string grade;


            Console.WriteLine("Enter a grade : ");
            grade = Console.ReadLine();

            switch (grade)
            {
                case "V":
                    Console.WriteLine("very good");
                    break;
                case "G":
                    Console.WriteLine("Good");
                    break;
                case "E":
                    Console.WriteLine("Exellent");
                    break;
                case "A":
                    Console.WriteLine("average");
                    break;
                case "F":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("invalid grade ");
                    break;
            }
            
            Console.ReadKey();




        }
    }
}