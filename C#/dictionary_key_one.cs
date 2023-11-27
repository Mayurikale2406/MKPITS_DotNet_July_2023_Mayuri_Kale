using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            Dictionary<string, string> di = new Dictionary<string, string>();
            di.Add("in", "India");
            di.Add("aus", "australlia");
            di.Add("du", "dubai");
            di.Add("lo", "london");
            di.Add("us", "united state");

            Console.WriteLine(di["aus"]);
            Console.WriteLine("dictionary has {0} item ", di.Count);
            Console.WriteLine("keys of the dictionary");

            List<string> keys= new List<string>(di.Keys);

            foreach(string key in keys)
            {
                Console.WriteLine("{0}", key);

            }
            Console.WriteLine("value of distionary");
            List<string> val= new List<string>(di.Values);
            foreach (string va in keys)
            {
                Console.WriteLine("{0}",va);

            }
            Console.WriteLine("Keys and values of the dictionary:");


            foreach (KeyValuePair<string, string> kvp in di)
            {
                Console.WriteLine("Key = {0}, Value = {1}",kvp.Key, kvp.Value);
            }
            Console.ReadKey();







        }

    }
}