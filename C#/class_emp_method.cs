using System;
namespace program
{
    class Employee
    {
        int employee_no;
        string employee_name;
        string designation;
        int salary;

        public void getdata(int en,string ed ,int es )
        {
            employee_no = en;
            designation = ed;
            salary = es;
            
        }
        public void displaydata()
        {
            Console.WriteLine("employee no : " + employee_no);
            Console.WriteLine("designation : " + designation);
            Console.WriteLine("salary : " + salary);
        }
        class program
        {
            static void Main()
            {
                Employee emp = new Employee();
                emp.getdata(123,"manager" ,25000);
                emp.displaydata();
                Console.ReadKey();
            }
            
        }
    }
}