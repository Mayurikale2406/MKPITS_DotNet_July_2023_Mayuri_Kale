using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            string name;
            int id;
            float unit;

            double amount ;
            double charge;
            double surcharge=0,netamount;
           
            Console.WriteLine("enter customer name : ");
            name = Console.ReadLine();
            Console.WriteLine("enter id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter unit : ");
            unit = Convert.ToSingle(Console.ReadLine());
            if(unit < 199)
            {
                charge =1.20 ;
            }
            else if(unit>=200 && unit<400)
            {
                charge = 1.50;
            }
            else if(unit >= 400 && unit < 600)
            {
                charge = 1.80;
            }
            else
            {
                charge = 2.00;
            }
            amount = unit * charge;

            if (amount > 400)
            
                surcharge = amount * 15 / 100;
                netamount = amount + surcharge;
            Console.WriteLine("amount : " + amount);
            Console.WriteLine("surcharge : " + surcharge);
            Console.WriteLine("netamount : " + netamount);
            Console.ReadKey();
        }
        
           
        
            
    }
}

