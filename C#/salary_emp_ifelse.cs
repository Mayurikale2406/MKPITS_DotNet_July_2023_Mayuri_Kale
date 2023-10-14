using System;

namespace salaryprogram
{
    class program
    {
         public static void Main()
        {
            int empno, salary;
            string empname, designation;
            float bonus=0;
            float totalsalary;

            Console.WriteLine("enter emp no :");
            empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter empname : ");
            empname = Console.ReadLine();

            Console.WriteLine("enter basicsalary : ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter designation : ");
            designation =Console.ReadLine();

            if (designation == "manager")
                bonus = 0.55f * salary;
            else if(designation == "clerk")
                bonus = 0.25f * salary;
            else if (designation == "peon")
                bonus = 0.10f * salary;
            else
                Console.WriteLine("designation invalid");
            totalsalary = salary + bonus;

            Console.WriteLine("empno :{0}, empname :{1}, basicsalary :{2}, designation :{3}", empno, empname, salary, designation);
            Console.WriteLine("bonus :  " + bonus);
            Console.WriteLine("total :  " + totalsalary);
            Console.ReadLine();
      

           

        }
    }
}