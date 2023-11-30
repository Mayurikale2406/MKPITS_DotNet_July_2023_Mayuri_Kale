using System;
using System.Text;

namespace program
{
    class program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("amitabh");
            sb.Append("bachan");
            Console.WriteLine(sb.ToString());
            object obj = sb;
            Console.WriteLine(obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
        }
    }
}