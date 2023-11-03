using System;
using System.Runtime.Intrinsics.X86;

namespace program
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;
        public Employee(int empno, string empname, string designation, int salary)
        {
            Console.WriteLine("constructor with paramter called ");
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("empno : " + empno );
            Console.WriteLine("empname : " + empname);
            Console.WriteLine("designation : " + designation);
            Console.WriteLine("salary : " + salary);
        }
    }
    class program
    {
        static void Main()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("enter employee number  : ");
            int e1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter employee name : ");
            string n1 = Console.ReadLine();
            Console.WriteLine("enter employee designation : ");
            string d1 = Console.ReadLine();
            Console.WriteLine("enter employee salary : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------------");
            Employee e= new Employee(e1,n1,d1,s1);
            Console.WriteLine("-----------------------------------");
            e.display();
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            ;

        }
    }
}