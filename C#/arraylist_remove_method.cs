using System;
using System.Collections;
namespace program

{
    class program
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();
            arr.Add(2);
            arr.Add(3);
            arr.Add(5);
            arr.Add(6);
            arr.Add(7);
            Console.WriteLine("array list before removing ");
           
            foreach(object ob in arr)
            {
                Console.WriteLine("roll no : " + ob);
                
            }
            arr.Remove(3);
            Console.WriteLine("array list after removing");
            foreach(object ob in arr)
            {
                Console.WriteLine("roll no : " + ob);
            }

            arr.RemoveAt(0);
            Console.WriteLine("array list after removeing at");
            foreach(object ob in arr)
            {
                Console.WriteLine("roll no : " + ob);
            }
            Console.ReadKey();
        }
        
        
    }
}