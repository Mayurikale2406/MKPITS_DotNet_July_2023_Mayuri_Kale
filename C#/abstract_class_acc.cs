using System;
namespace program
{
    abstract class account
    {
        public int actno;
        public int bal = 1000;
        public abstract void deposite(int amount);
        public void showbalance()
        {
            Console.WriteLine("balance amount for account no {0} is {1}", actno, bal);
        }

    }
    class current : account
    {
        public override void deposite(int amount)
        {
            bal = bal + amount;
        }
    }
    class saving : account
    {
        public override void deposite(int amount)
        {
            int interest = 200;
            bal = bal +amount+interest;
        }
    }
    class program
    {
        static void Main()
        {
            Console.WriteLine("enter account number : ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited : ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter account type saving or current ");
            string acttype = Console.ReadLine();
            account act = null;
            if(acttype=="saving")
            {
                act = new saving();
            }
            else if(acttype=="current")
            {
                act = new current();
            }
            act.actno = actno;
            act.deposite(amt);
            act.showbalance();

        }
    }
}