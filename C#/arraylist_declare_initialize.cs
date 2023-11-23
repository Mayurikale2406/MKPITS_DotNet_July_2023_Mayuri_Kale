//Declaration and Initialization:

//Declare an ArrayList named myList.
//Initialize myList with three integer values: 10, 20, and 30.

using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            ArrayList arr = new ArrayList();
            arr.Add(10);
            arr.Add(20);
            arr.Add(30);
            foreach(object ob in arr)
            {
                Console.WriteLine("declaraed and initialization  value : " + ob );

                
            }
            Console.ReadKey();
        }
    }
}