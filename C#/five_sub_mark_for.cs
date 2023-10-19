using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Schema;

namespace program
{
    class program
    {
        public static void Main()
        {
            int mark;
            int total = 0;
            float per;
            string grade = null;


            for (int cnt = 0; cnt < 5; cnt++)
            {


                Console.WriteLine("Enter a subject mark : ");
                mark = Convert.ToInt32(Console.ReadLine());
                total = total + mark;
            }
                per = ((float)total / 500) * 100;
                
            if(per>=90)
            {
                grade = "A++";

            }
            else if(per>=80 && per<=90)

            {
                grade = "A";
                 
            }
            else if (per >=70 && per <= 80)

            {
                grade = "B";

            }
            else if (per >= 60 && per <= 50)

            {
                grade = "C";

            }
            Console.WriteLine("Total of five Subject Marks : " + total);
            Console.WriteLine("Percentage of five Subject Marks : " + per);
            Console.WriteLine("grade " + grade);
        
        }

    }
}