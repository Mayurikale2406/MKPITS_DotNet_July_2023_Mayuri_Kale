using System;
using System.Collections;
namespace program
{
    class program
    {
        static void Main()
        {
            SortedList st = new SortedList();
            st.Add("005", "mayuri");
            st.Add("008", "vrushali");
            st.Add("003", "sayali");
            st.Add("001", "priya");
            if(st.ContainsValue("ayushi"))
            {
                Console.WriteLine("already in a list");
            }
            else
            {
                st.Add("009" , "ayushi");
            }
            ICollection key = st.Keys;
            foreach(string s in key)
            {
                Console.WriteLine(s + ":" + st[s]);
            }
            Console.ReadLine();
        }
    }
}