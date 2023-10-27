using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int[] mark = new int [3];
            int total = 0;
            float per=0;
            string grade=null
                ;

            for (int cnt = 0; cnt < 3; cnt++)
            {
                Console.WriteLine("enter subject marks(3 subject marks) : ");
                mark[cnt] = Convert.ToInt32(Console.ReadLine());
            }
            for(int cnt=0;cnt<3;cnt++)
            {
                total = total + mark[cnt];
                per = (total / 300.0f) * 100.0f;
               
            }
            if(per>=75)
            {
                grade = "distinction";
            }
            else if(per<=75 && per>60)
            {
                grade = "first class";
            }
            else if(per<=60 && per>50)
            {
                grade = "second class";
            }
            else
            {
                grade = "fail";
            }

            Console.WriteLine("total : " + total);
            Console.WriteLine("percentage : " + per);
            Console.WriteLine("grade : " + grade);
            Console.ReadKey();

        }
    }
}