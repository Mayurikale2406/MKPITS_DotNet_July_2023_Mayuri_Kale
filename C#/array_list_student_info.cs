using System;
using System.Collections;

namespace program
{
    class program
    {
        static void Main()
        {
            ArrayList ar = new ArrayList();
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);
            ar.Add(4);

            foreach(object ob in ar)
            {
                Console.WriteLine("student roll no : " + ob);
            }
            Console.WriteLine("capacity : {0} " , ar.Capacity);
            Console.WriteLine("count : {0}" , ar.Count);

            Console.ReadLine();
        }
    }
}