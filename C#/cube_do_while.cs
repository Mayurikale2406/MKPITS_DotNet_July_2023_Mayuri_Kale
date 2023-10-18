using System;
namespace program
{
    class program
    {
        public static void Main()
        {
            int num, cnt = 1;
            int result = 0;
            Console.WriteLine("enter a number : ");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                result = cnt * cnt * cnt;
                cnt++;
            }
            while (cnt <= num);
            {

                Console.WriteLine("number is : {0} and cube of the {1} is {2}", cnt, cnt, result);
                Console.ReadKey();
            }
        }
    }
}
