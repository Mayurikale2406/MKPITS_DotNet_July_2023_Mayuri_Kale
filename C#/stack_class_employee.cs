//create a stack  collection of employee class(empno, empname , salary
//and designation)
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace program
{
    class employee
    {
        public int empno;
        public string empname;
        public int salary;
        public string designation;
        public employee(int empno,string empname,int salary,string designation)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
            this.designation = designation;
        
        }

    }
    class program
    {
        public static void Main()
        {
            Stack st = new Stack();
            
        }
    }
}