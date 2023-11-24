using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            Stack s = new Stack();
            s.Push("Mayuri");
            s.Push("vrushali");
            s.Push("priya");
            s.Push("ayushi");
            foreach(string val in s)
            {
                Console.WriteLine("name : " + val);
            }
            s.Push("prachi");
            Console.WriteLine("--------------------");
            Console.WriteLine("last item added : " + s.Peek());
            Console.WriteLine("----------------------");
            Console.WriteLine("after peek method");
            Console.WriteLine("---------------------");
            foreach(string val in s)
            {
                Console.WriteLine("name : " + val);
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("last item added : " + s.Pop());
            Console.WriteLine("----------------------");
            Console.WriteLine("after pop method");
            Console.WriteLine("---------------------");
            foreach(string val in s)
            {
                Console.WriteLine("name : " + val);
            }
            Console.ReadLine();
        }
    }
}