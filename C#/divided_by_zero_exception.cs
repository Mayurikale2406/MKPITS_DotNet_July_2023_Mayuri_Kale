using System;
using System.Text.Json.Serialization;

namespace program
{
    class DivNumber
    {
        int result;
        DivNumber()
        {
            result = 0;
        }
        public void Division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException ee)
            {
                Console.WriteLine("exception :  {0}", ee);
            }
            finally
            {
                Console.WriteLine("Result:  {0}", result);
            }
        }
        static void Main()
        {
            DivNumber d = new DivNumber();
            d.Division(25, 5);
            Console.ReadKey();
        }
        
    }
}