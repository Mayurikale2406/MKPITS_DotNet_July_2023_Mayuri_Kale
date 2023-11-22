using System;
namespace program
{
    class student
    {
        protected int rno;
        protected string name;

        public void getdata()
        {
            rno = 12;
            Console.WriteLine("rno : " + rno);
            name = "mayuri";
            Console.WriteLine("name  : " + name);

        }
    }
    class program
    {
        static void Main()
        {
            student s = new student();
           // s.rno = "12";
            //s.name = "mayu";
            s.getdata();
        }
    }
}
