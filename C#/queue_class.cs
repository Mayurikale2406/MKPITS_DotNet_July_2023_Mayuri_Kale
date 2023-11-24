using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            Queue qu = new Queue();
            qu.Enqueue("mayuri");
            qu.Enqueue("sayali");
            qu.Enqueue("prachi");
            qu.Enqueue("priya");

            Console.WriteLine(" -----------Enqueue--------- ");
            foreach (string val in qu)
            {
       
                Console.WriteLine(val);
            }
            qu.Dequeue();
            Console.WriteLine(" -----------Dequeue--------- ");
            foreach (string val in qu)
            {
             
                Console.WriteLine(val);
            }
        }
    }
}