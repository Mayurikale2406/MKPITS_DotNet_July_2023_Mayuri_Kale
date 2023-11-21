//Provide an example of a simple class in C# with at least two attributes and one method.
//Create an object of the class you defined and demonstrate how to access its attributes and call its method.
using System;
using System.ComponentModel;
using System.Net.NetworkInformation;

namespace program
{
    class addition
    {
        public int num;
       public  int add;

    public void getdata(int num)
        {
            this.num = num;
         
        }
        public void displaydata()
        {
            add = num + num;
            Console.WriteLine("addition : " + add);
        }
        class program
        {
            static void Main()
            {
                addition add = new addition();
                add.getdata(2);
                add.displaydata();
                Console.ReadKey();
            }
        }
    }

}
