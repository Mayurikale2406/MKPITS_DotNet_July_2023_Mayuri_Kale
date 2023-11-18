using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class student
    {
        public static void display()
        {
            Console.WriteLine("hello");
        }
        public void sayhi()
        {
            Console.WriteLine("hi");
        }
    }
    class Program
    {
        //creating nonstatic display method

        static void Main(string[] args)
        {
            student.display();
            //    student.sayhi();// error
            student s = new student();
            s.sayhi();

        }
    }
}
