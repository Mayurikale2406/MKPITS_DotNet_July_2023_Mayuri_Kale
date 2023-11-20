using System;
namespace program
{
    abstract class account
    {
        public abstract void deposite();
        public void showbalance()
        {
            Console.WriteLine("balance method");

        }
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
            act.showbalance();
            Console.ReadKey();
        }
    }
}