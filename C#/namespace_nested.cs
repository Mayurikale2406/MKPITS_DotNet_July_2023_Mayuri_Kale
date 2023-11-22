using first.second;
using System;
namespace first
{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("hello from first namespace");
        }
    }
    namespace second
    {
        public class  welcome
        {
            public void sayhello()
            {
                Console.WriteLine("hello from second namspace");
            }
        }
    }
    namespace program
    {
        class program
        {
            static void Main()
            {
                hello h1 = new hello();
                h1.sayhello();
                welcome w = new welcome();
                w.sayhello();
            }
        }
    }

}