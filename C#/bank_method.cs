using System;
using System.ComponentModel.DataAnnotations;

namespace program
{
    class program
    {
        static void bank(int actno,int amount,int deposite,int withdrawl)
        {
            withdrawl = amount - withdrawl;
            Console.WriteLine("withdrawl :" + withdrawl);

            deposite = amount + deposite;
            Console.WriteLine("deposite : " + deposite);

        }
        static void Main()
        {
            int actno;

            Console.WriteLine("enter account number : ");
            actno = Convert.ToInt32(Console.ReadLine());
            int amount;
            Console.WriteLine("enter a amount : ");
            amount = Convert.ToInt32(Console.ReadLine());
            int withdrawl;
            Console.WriteLine("enter withdrawl ");
            withdrawl = Convert.ToInt32(Console.ReadLine());

            int deposite;
            Console.WriteLine("enter deposite");
            deposite = Convert.ToInt32(Console.ReadLine());

            bank(actno, amount, deposite, withdrawl);
        }
    }
}