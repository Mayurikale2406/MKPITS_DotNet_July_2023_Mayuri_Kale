using System;
namespace program
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public Employee()
        {
            empno = 1;
            empname = "mayuri";
            designation = "manager";
            salary = 50000;
        }
        public void display()
        {
            Console.WriteLine("emp no : " + empno);
            Console.WriteLine("emp name : " + empname);
            Console.WriteLine("designation : " + designation);
            Console.WriteLine("salary : " + salary);
        }
    }
    class program
    {
        public void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.ReadKey();
        }
    }
}