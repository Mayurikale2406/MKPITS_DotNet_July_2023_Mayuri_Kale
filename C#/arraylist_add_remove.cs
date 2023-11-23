using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();
            arr.Add(1);
            arr.Add(2);
            arr.Add(3);
            arr.Add(4);
            Console.WriteLine("array list before adding ");
        foreach(object o in arr)
            {
                Console.WriteLine(o);
            }
            arr.Remove(3);
            Console.WriteLine("after remove array list");

        foreach(object o in arr)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
        }
    }
}