using System;
using System.Collections;

namespace program
{
    class program
    {
        static void Main()
        {
            ArrayList ar = new ArrayList();
            ar.Add("manish");
            ar.Add("sunil");
            ar.Add("chetan");
            ar.Add("pranay");

            foreach(object obj in ar)
            {
                Console.WriteLine("student name : " + obj);
            }
        }
    }
}