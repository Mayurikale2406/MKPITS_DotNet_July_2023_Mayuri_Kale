using System;
namespace program
{
    class student
    {
        public string name { get; set; }
        public string id { get; set; }
        public string emailid { get; set; }

    }
   class program
    {
        static void Main()
        {
            //setting value
            student stud = new student();
            stud.name = "mayuri";
            stud.id = "101";
            stud.emailid = "mayuri@gmail.com";

            //getting value

            Console.WriteLine("student name : " + stud.name);
            Console.WriteLine("student id : " + stud.id);
            Console.WriteLine("student emailid : " + stud.emailid);

            Console.ReadKey();
        }
    }
}
