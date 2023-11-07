using System;
namespace program
{
    class calculate
    {
        public void additon(int n1,int n2 )
        {
            int res = n1 + n2;
            Console.WriteLine("addition of two int : " + res);
        }
        public void addition(float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("additon of two float : " + res);
        }
        class program
        {
            static void Main()
            {
                calculate cal = new calculate();
                cal.additon(2, 4);
                Console.WriteLine("----------------------");
                Console.WriteLine("addition of two float ");
                cal.addition(2.2f, 3.5f);
                Console.ReadKey();
            }
        }
    }
}