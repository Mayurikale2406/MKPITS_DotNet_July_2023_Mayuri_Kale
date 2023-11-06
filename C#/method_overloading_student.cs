using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Student
    {
        int rollno;
        string  name;
        string course;

        public void getdata()
        {
            rollno = 1;
            name = "mayuri";
            course = "dotnet";
            

        }
        //method overloaded 
        public void getdata(int rollno)
        {
            this.rollno = rollno;

        }
        public void getdata(int rollno, String name)
        {
            this.rollno = rollno;
            this.name = name;

        }
        public void getdata(int rollno, String name, String course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;

        }
       
        public void display()
        {
            Console.WriteLine("roll no : " + rollno);
            Console.WriteLine("name : " +   name);
            Console.WriteLine("course : " + course);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student b = new Student();
            b.getdata();
            b.display();
            Console.WriteLine("-----------------book1 details ----------");
            Student b1 = new Student();
            b1.getdata(09);
            b1.display();

            Console.WriteLine("-----------------book1 details ----------");
            Student b2 = new Student();
            b2.getdata(111,"mayuri");
            b2.display();

            Console.WriteLine("-----------------book1 details ----------");

            Student b3 = new Student();
            b3.getdata(111,"mayuri","dotnet");
            b3.display();

            

            Console.ReadLine();

        }
    }
}
