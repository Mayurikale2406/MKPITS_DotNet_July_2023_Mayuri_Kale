using System;
namespace program
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }

    public void display()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("account details of customer");
            Console.WriteLine("AccountNumber : " + AccountNumber);
            Console.WriteLine("AccountHolderName : " + AccountHolderName);
            Console.WriteLine("Balance : " + Balance);
        }
        public void transfer(BankAccount ba)
        {
            Balance = Balance + ba.Balance;
            ba.Balance = 0;
        }
        public void showbalance()
        {
            Console.WriteLine("current balance for account no {0} is {1}", AccountNumber, Balance);

        }
    }
    class program
    {
        static void Main()
        {
            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 1;
            b1.AccountHolderName = "mayuri";
            b1.Balance = 100;

            b1.display();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 2;
            b2.AccountHolderName = "vrushali";
            b2.Balance = 50;

            b2.display();

            b2.transfer(b1);

            Console.WriteLine("-----------------");
            Console.WriteLine("balance after transation");
            Console.WriteLine("-----------------");

            b1.showbalance();
            b2.showbalance();

            Console.ReadLine();
        }
    }
}