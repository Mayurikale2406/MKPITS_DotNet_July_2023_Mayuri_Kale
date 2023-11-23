using first.second;
using System;

namespace first

{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("hello namespace");
        }
    }
namespace second
    {
        public class welcome
        {
            public void sayhello()
            {
                Console.WriteLine("hello from second namespace");
            }
        }
    }
    public class Testnamespace
    {
        public static void Main()
        {
            hello h1 = new hello();
            welcome w1 = new welcome();
            h1.sayhello();
            w1.sayhello();
        }
    }

}