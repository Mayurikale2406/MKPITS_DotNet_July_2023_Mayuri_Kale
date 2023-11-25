using System;
using System.Collections;
using System.Data;

namespace program
{
    class student
    {
        public int rno;
        public string name;
        public student (int rno,string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    class program
    {
        static void Main()
        {
            student s1 = new student(11,"amit");
            student s2 = new student(12, "ravi");
            student s3 = new student(13, "Manish");

            Queue s = new Queue();
            s.Enqueue(s1);
            s.Enqueue(s2);
            s.Enqueue(s3);

            foreach (student val in s)
            {
                Console.WriteLine("rno : " + val.rno);
                Console.WriteLine("name : " + val.name);
            }
            student r = (student) s.Dequeue();
            Console.WriteLine("------------------------");
            Console.WriteLine("item dequeue " + r.rno + ": " + r.name);
            Console.WriteLine("-----------------------");
            Console.WriteLine("after dequeue");
            Console.WriteLine("----------------------");

            foreach(student val in s)
            {
                Console.WriteLine("name : " + val.name);
            }
            Console.ReadLine();

        }
    }
}