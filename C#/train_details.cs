using System;
namespace trainprogram
{
    class program
    {
        public static void Main()
        {
            string origin, destination,classname,passengername;
            string date;
            int trainno;
            int total_fare;

            Console.WriteLine("enter a origin place : ");
            origin = Console.ReadLine();
            Console.WriteLine("enter a  destination : ");
            destination = Console.ReadLine();
            Console.WriteLine("enter a  classname : ");
            classname = Console.ReadLine();
            Console.WriteLine("enter a  passengername : ");
            passengername = Console.ReadLine();
            Console.WriteLine("enter a  date : ");
            date = (Console.ReadLine());
            Console.WriteLine("enter a  trainno : ");
            trainno =Convert.ToInt32(Console.ReadLine());

            if (destination == "mumbai")
                total_fare = 1500;
            else if (destination == "nagpur")
                total_fare = 1000;
            else if (destination == "pune")
                total_fare = 900;
            else
                Console.WriteLine("invalid destination");

            Console.WriteLine("origin :{0}, destination :{1},  passengername :{2} ,date :{3}, trainno :{4}", origin, destination, passengername, date, trainno);
            Console.WriteLine("totalfare : " + total_fare);
            Console.ReadKey();


        }
    }
}