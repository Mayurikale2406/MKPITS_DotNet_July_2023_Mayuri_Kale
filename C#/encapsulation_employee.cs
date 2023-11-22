using System;
namespace program
{
    class employee
    {
        public string empname { get; set; }

    }
    class program
    {
        static void Main()
        {
            employee emp = new employee();
            emp.empname = "mayuri";
            Console.WriteLine("employee name : " + emp.empname);
        }
    }
}