using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            string grade;

            Console.WriteLine("Input grade : ");
            grade = Console.ReadLine();

            if (grade == "E")
            {
                Console.WriteLine(" Exellent");
            }

            else if (grade == "V")
            {
                Console.WriteLine(" Very good");
            }

            else if (grade == "G")
            {
                Console.WriteLine(" Good");
            }

            else if (grade == "A")
            {
                Console.WriteLine(" Average");
            }

            else if (grade == "F")
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }
}


            