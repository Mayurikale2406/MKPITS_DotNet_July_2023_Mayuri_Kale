using System;
using System.Collections;
using System.Collections.Generic;
namespace program
{
    class program
    {
        static void Main()
        {
            List<string> l = new List<string>();

            l.Add("java");
            l.Add("c#");
            l.Add("python");
            Console.WriteLine("---------adding-----");

            Console.WriteLine(l.Contains("c#"));
            Console.WriteLine(l[1]);
            Console.WriteLine(l[2]);

            l.Remove("c#");
            Console.WriteLine("---------remove-------");
            foreach (string lang in l)
            {
                Console.WriteLine(lang);
            }
            Console.WriteLine(l.Contains("c#"));
            Console.WriteLine("---------Insert--------");
            l.Insert(2, "dotnet");
            foreach (string lang in l)
            {
                Console.WriteLine(lang);
            }
            Console.WriteLine("---------after sorting------");
            l.Sort();
            foreach(string lang in l)
            {
                Console.WriteLine(lang);
            }

            Console.ReadKey();
        }
    }
}