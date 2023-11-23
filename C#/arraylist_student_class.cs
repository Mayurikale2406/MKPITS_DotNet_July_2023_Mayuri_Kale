using System;
using System.Collections;
namespace program
{
    class student
    {
        public int rno;
        public string name;
    public student(int rno,string name)
        {
            this.rno = rno;
            this.name = name;

        }
    }
    class program
    {
        static void Main()
        {
            student s1 = new student(12, "mayuri");
            student s2 = new student(9, "sayali");
            student s3 = new student(10, "vrushali");

            ArrayList arr = new ArrayList();
            arr.Add(s1);
            arr.Add(s2);
            arr.Add(s3);

            foreach(student s in arr)
            
            {
                Console.WriteLine("rno : " + s.rno);
                Console.WriteLine("name : " + s.name);
            }
        }
    }
}