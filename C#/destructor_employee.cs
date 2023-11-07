using System;
namespace program
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("constructor called");
        }
        ~Employee()
        {
            Console.WriteLine("destructor called");
        }
    }
    class program
    {
        static void Main()
        {
            Employee emp = new Employee();
            Console.ReadKey();
            Employee emp2 = new Employee();
            Console.ReadKey();
        }
    }
}