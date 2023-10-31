using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace program
{
    class student
    {
        string student_name;
        int student_rollno;
        int[] subjectmark;


        public void getdata(string name, int rno, int[] m)
        {
            this.student_name = name;
            this.student_rollno = rno;
            this.subjectmark = m;


        }
        public void displaydata()
        {
            Console.WriteLine("roll no : " + student_rollno);
            Console.WriteLine("name : " + student_name);
            int total = 0;
            for (int i = 0; i < 3; i++)
            {
                total = total + subjectmark[i];
            }
            float avg = total / 3.0f;
            Console.WriteLine("avg : " + avg);

        }

    }
    class program
    {
        static void Main()
        {
            student stud = new student();
            Console.WriteLine("enter name");
            string nam = Console.ReadLine();
            Console.WriteLine("enter a roll no & name ");
            int r = Convert.ToInt32(Console.ReadLine());
            
            int[] subjectmark = new int[3];
            Console.WriteLine("enter 3 subject marks ");
            for (int i = 0; i < 3; i++)
            { 
               
           subjectmark [i] = Convert.ToInt32(Console.ReadLine());
            }

            stud.getdata(nam,r, subjectmark); 
            stud.displaydata();
            Console.ReadKey();
        }




    }
}