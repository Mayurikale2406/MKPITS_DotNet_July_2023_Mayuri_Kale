using System;
namespace program
{
    interface bank
    {
        string deposit(int actno, int amt);

    }
    class account
    {
        public int actno;
        public int bal = 1000;

    }
    class saving : account,bank
    {
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited succesfully , bal is " + bal;
        }
    }
    class program
    {
        static void Main()
        {
            bank b = new saving();
            string res = b.deposit(1,200);
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}