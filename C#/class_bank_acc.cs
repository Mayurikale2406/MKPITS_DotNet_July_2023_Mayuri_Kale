//Bank Customer Class: Create a BankCustomer class with properties for CustomerName, AccountNumber, and Balance.
//Instantiate the BankCustomer class and simulate deposits and withdrawals from the customer's account.
//Display the final balance.
using System;
namespace program
{

    class BankCustomer
    {
        string CustomerName;
        int AccountNumber;
        int Balance = 0;
        int Deposite;
        int Withdrawal;

        public void GetData(string name, int an, int bal, int dep, int with)
        {
            CustomerName = name;
            AccountNumber = an;
            Balance = bal;
            Deposite = dep;
            Withdrawal = with;
        }

        public void DisplayData()
        {
            Console.WriteLine("Customer Name: " + CustomerName);
            Console.WriteLine("Account Number: " + AccountNumber);

            Balance = Balance + Deposite;
            Console.WriteLine("Deposite: " + Deposite);
            Balance = Balance - Withdrawal;
            Console.WriteLine("Withdrawal: " + Withdrawal);
            Console.WriteLine("Current Balance: " + Balance);
        }
    }

    class Program
    {
        static void Main()
        {
            BankCustomer bc = new BankCustomer();
            Console.WriteLine("Enter customer details:");
            Console.WriteLine("Enter customer name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter account number: ");
            int an = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter initial balance: ");
            int bal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter deposit amount: ");
            int dep = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter withdrawal amount: ");
            int with = Convert.ToInt32(Console.ReadLine());

            bc.GetData(name, an, bal, dep, with);
            bc.DisplayData();
            Console.ReadKey();
        }
    }
}

