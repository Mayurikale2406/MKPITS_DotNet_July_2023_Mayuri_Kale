using System;
using System.Xml.Schema;

namespace program
{
    class program
    {
        static void Main()
        {
            int sub1, sub2, sub3, sub4, sub5, total;
            float per;
            string grade = null;

            Console.WriteLine("enter a sub 1 mark : ");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a sub 2 mark : ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a sub 3 mark : ");
            sub3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a sub 4 mark : ");
            sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter a sub 5 mark : ");
            sub5 = Convert.ToInt32(Console.ReadLine());

            total = sub1 + sub2 + sub3 + sub4 + sub5;
            Console.WriteLine("Total Mark : {0}", total);
            per = (total / 500.0f) * 100.0f;
            Console.WriteLine("percentage : {0}", per);
            if (per >= 90)
            {
                grade = "A++";
            }
            else if (per >= 80 && per <= 90)
            {
                grade = "A";
            }
            else if(per>=70 && per<=80)
            {
                grade = "B";
            }
            else if(per>=60 && per<=70)
            {
                grade = "c";

            }
            else
            {
                grade = "fail";
            }

            Console.WriteLine("grade : {0}", grade);

            Console.ReadLine();

          



        }
    }
}