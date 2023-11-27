using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            LinkedList<int> l = new LinkedList<int>();
            l.AddLast(22);
            l.AddLast(34);
            l.AddLast(56);
            l.AddLast(24);

            LinkedListNode<int> node = l.Find(22);
            l.AddBefore(node, 3);
            foreach(int li in l)
            {
                Console.WriteLine(li);
            }
            Console.ReadKey();
        }
    }
}