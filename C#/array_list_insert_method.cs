using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();
            arr.Add(20);
            arr.Add(23);
            arr.Add(34);
            arr.Add(10);

            Console.WriteLine("array list without insert a value");
            foreach(object o in arr)
            {
                Console.WriteLine("roll no : " + o); 
            }
            arr.Insert(2, 17);
            Console.WriteLine("array list without insert a value");
            foreach(object o in arr)
            {
                Console.WriteLine("roll no : " + o);
            }
            Console.ReadLine();
        }
    }
}