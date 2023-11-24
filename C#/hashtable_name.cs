using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("123", "mayuri");
            ht.Add("234", "vrushali");
            ht.Add("678", "sayali");
            ht.Add("890", "priya");
            if(ht.ContainsValue("ayushi"))
            {
                Console.WriteLine("already in a list");
            }
            else
            {
                ht.Add("876", "ayushi");
            }

            ICollection key = ht.Keys;
            foreach(string st in key)
            {
                Console.WriteLine(st + ":" + ht[st]);
            }
            Console.ReadKey();
        }
    }
}