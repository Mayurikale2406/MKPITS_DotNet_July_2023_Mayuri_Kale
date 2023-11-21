using System;
using System.Runtime.InteropServices;

namespace program
{
    interface bank
    {
        string deposit(int actno, int amt);


    }
    class saving : bank
    {
        int actno;
        int balance = 500;
        public string deposit(int actno,int amt)
        {
            this.actno = actno;
            balance = balance + amt;
            return "deposited successfully , bal is " + balance;
        }
    }
    class program
    {
        static void Main()
        {
            bank b = new saving();
            string str = b.deposit(1, 200);
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
    