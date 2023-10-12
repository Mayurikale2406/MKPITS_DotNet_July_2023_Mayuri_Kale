using System;
namespace age
{
    class program
    {
        public static void Main(string[]args)
        {
            int age;

            Console.WriteLine("enter a age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("you look older then age : " + age);
        }
    }
}