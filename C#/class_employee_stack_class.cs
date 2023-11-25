//create a stack  collection of employee class(empno, empname , salary and
//designation)
using System;
using System.Collections;
namespace program
{
    class Employee
    {
        public int empno;
        public string empname;
        public int salary;
        public string designation;

        public Employee(int empno,string empname,int salary,string designation)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
            this.designation = designation;

        }
        class program
        {
            static void Main()
            {
                Employee e1 = new Employee(11, "mayuri", 50000, "Owener");
                Employee e2 = new Employee(12, "vrushali", 40000, "manager");
                Employee e3 = new Employee(13, "sayali", 30000, "developer");
                Employee e4 = new Employee(14, "vibha", 20000, "coder");

                Stack st = new Stack();
                Console.WriteLine("After Peek");
                st.Push(e1);
                st.Push(e2);
                st.Push(e3);
                st.Push(e4);

                foreach(Employee e in st)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Employee Id : " + e.empno);
                    Console.WriteLine("Employee Name : " + e.empname);
                    Console.WriteLine("Employee Salary : " + e.salary);
                    Console.WriteLine("Employee designation : " + e.designation);
                    Console.WriteLine("-----------------------------");
               

                }
                Console.WriteLine("After Pop");
                st.Pop();
                
                    foreach(Employee e in st)
                {
                    Console.WriteLine("-----------------------------");
                    Console.WriteLine("Employee Id : " + e.empno);
                    Console.WriteLine("Employee Name : " + e.empname);
                    Console.WriteLine("Employee Salary : " + e.salary);
                    Console.WriteLine("Employee designation : " + e.designation);
                    Console.WriteLine("--------------------------------");

                }
              





            }
           
        }

    }
}