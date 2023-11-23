using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            ArrayList ar = new ArrayList();
            ar.Add(19);
            ar.Add(39);
            ar.Add(9);

            Console.WriteLine("array list collection without sorting");

            foreach(int i in ar)
            {
                Console.WriteLine("student roll no : " + i);
            }
            ar.Sort();

            Console.WriteLine("array list collection with sorting");

            foreach(int i in ar)
            {
                Console.WriteLine("student roll no : " + i);
            }
            Console.ReadLine();
        }
    }
}