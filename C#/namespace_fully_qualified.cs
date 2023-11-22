using System;
namespace first
{
    public class Hello
    {
        public void sayhello()
        {
            Console.WriteLine("hello first namespace");
        }
    }
    namespace second
    {
        public class Hello
        {
            public void sayhello()
            {
                Console.WriteLine("hello second namespace");
            }
        }
        public class testnamespace
        {
            public static void Main()
            {
                first.Hello f = new first.Hello();
                second.Hello f2 = new second.Hello();
                f.sayhello();
                f2.sayhello();

            }
        }
    }
}