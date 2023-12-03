using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class person
    {
        public string name;
        public string address;

    }
    class student : person
    {
        public int rno;
        public int marks;

    }
    class employee : person
    {
        public int salary;
        public string designation;
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.name = "vrushali";
            s.address = "nagpur";
            s.rno = 44;
            s.marks = 111;
            Console.WriteLine("--------------- student details ----------");
            Console.WriteLine("name " + s.name);
            Console.WriteLine("addres " + s.address);
            Console.WriteLine("rno " + s.rno);
            Console.WriteLine("marks" + s.marks);
            //creating object of empclass
            employee emp = new employee();
            emp.name = "mayuri";
            emp.address = "mumbai";
            emp.salary = 53000;
            emp.designation = "manager";
            Console.WriteLine("--------------- emp details ----------");
            Console.WriteLine("name " + emp.name);
            Console.WriteLine("addres " + emp.address);
            Console.WriteLine("salary " + emp.salary);
            Console.WriteLine("designation" + emp.designation);
        }
    }
}
