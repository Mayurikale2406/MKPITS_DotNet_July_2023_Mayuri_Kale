using System;
namespace program
{
    interface bank
    {
        string deposit(int actno, int amt);
        string withdraw(int actno, int amt);
    }
    class account
    {
        public int actno;
        public int bal = 1000;

        public string showbalance()
        {
            return "balance is " + bal;
        }

    }
    class saving : account, bank
    {
        public string deposit(int actno, int amt)
        {
            this.actno = actno;
            bal = bal + amt;
            return "deposited succesfully, balance is : " + bal;
        }



        public string withdraw(int actno, int amt)
        {
            this.actno = actno;
            bal = bal - amt;
            return "withdraw succesfully , balance is : " + bal;
        }
    }

    
    class program
    {
        static void Main()
        {
            bank b = new saving();
            string res= b.deposit(1, 200);
            Console.WriteLine(res);

            string res1 = b.withdraw(1,100);
            Console.WriteLine(res1);

            Console.ReadKey();


        }
    }
}