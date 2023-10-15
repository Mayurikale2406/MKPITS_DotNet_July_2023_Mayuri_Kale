using System;
namespace rootprogram
{
    class program
    {
        public static void Main()
        {
            int temp;
            Console.WriteLine("enter a temperature in centigrade :");
            temp = Convert.ToInt32(Console.ReadLine());
            /*Temp < 0 then Freezing weather
Temp 0 - 10 then Very Cold weather
Temp 10 - 20 then Cold weather
Temp 20 - 30 then Normal in Temp
Temp 30 - 40 then Its Hot
Temp >= 40 then Its Very Hot*/
            if (temp < 0)
                Console.WriteLine("freezing weather");
            else if (temp >= 0 && temp <= 10)
                Console.WriteLine("very cold weather ");
            else if (temp > 10 && temp <= 20)
                Console.WriteLine("cold in weather");
            else if (temp > 20 && temp <= 30)
                Console.WriteLine("normal in temp");
            else if (temp > 30 && temp <= 40)
                Console.WriteLine("its hot");
            else if (temp >= 40)
                Console.WriteLine("its very hot");

            Console.ReadKey();


        }
    }
}