using System;
namespace additionProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            int num1,num2,add;

            Console.WriteLine("Enter a num1");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a num2");
            num2=Convert.ToInt32(Console.ReadLine());
            add=   num1+num2;
            Console.WriteLine("Result : " + add);
            Console.ReadKey();
        }
    }
}