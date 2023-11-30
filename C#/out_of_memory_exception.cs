using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace program
{
    class program
    {
        static void Main()
        {
            string name = "vrushali";
            string sub = "Csharp";
            Console.WriteLine("length of name : " + name.Length);
            Console.WriteLine("lenght of sub : " + sub.Length);

            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(sub);
            }
            catch(OutOfMemoryException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("bye");
        }
    }
}