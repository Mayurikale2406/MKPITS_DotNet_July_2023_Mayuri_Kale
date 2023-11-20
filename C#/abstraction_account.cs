using System;
using System.Net.Http.Headers;

namespace program
{
    abstract class account
    {
        public abstract void deposite();
    }
    class saving : account
    {
        public override void deposite()
        {
            Console.WriteLine("hello from saving deposite method");
        }
    }
    class program
    {
        static void Main()
        {
            account act = new saving();
            act.deposite();
        }
    }
}