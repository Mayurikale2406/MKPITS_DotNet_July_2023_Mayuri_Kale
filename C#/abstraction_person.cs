using System;
namespace program
{
    abstract class person
    {
        public abstract void display();
        public void showdata()
        {
            Console.WriteLine("hello from showdata");
        }
    }
    class student : person
    {
        public override void display()
        {
            Console.WriteLine("hello from display method");

        }
    }
    class program
    {
        static void Main()
        {
           
            student s = new student();
            s.display();
            s.showdata();
        }
    }
}