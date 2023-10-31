using System;
namespace program
{
    class person
    {
        string person_name;
        int person_age;
        string person_add;

        public void getdata(string person_name, int person_age,string person_add)
        {
            this.person_name = person_name;
            this.person_age = person_age;
            this.person_add = person_add;

        }
        public void displaydata()
        {
            Console.WriteLine("person name : " + person_name);
            Console.WriteLine("person age : " + person_age);
            Console.WriteLine("person address : " + person_add);
        }
        class program
        {
            static void Main()
            {
                person per = new person();
                per.getdata("mayuri ", 22, "nagpur");
                per.displaydata();

                Console.ReadKey();
            }
            
        }
            

    }
}