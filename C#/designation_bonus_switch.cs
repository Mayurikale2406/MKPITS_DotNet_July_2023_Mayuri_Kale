using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            string designation;
            int bonus = 0;
            

            Console.WriteLine("(Enter a designation) manager,clerk,peon : ");
            designation = Console.ReadLine();

            switch (designation)
            {
                case "manager":
                    bonus = 10000;
                    break;
                case "clerk":
                    bonus = 5000;
                    break;
                case "peon":
                    bonus = 2000;
                    break;
                default:
                    Console.WriteLine("invalid designation ");
                    break;
            }
            Console.WriteLine("bonus " + bonus);
                    Console.ReadKey();



            
        }
    }
}
