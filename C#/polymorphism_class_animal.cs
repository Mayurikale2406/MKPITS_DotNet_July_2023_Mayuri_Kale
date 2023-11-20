using System;
namespace program
{
    public class animal
    {
        public virtual void eat()
        {
            Console.WriteLine("eating");
        }
    }
    public class dog : animal
    {
        public override void eat()
        {
            Console.WriteLine("eating bread");
        }
    }
    public class Test polymorphism
       
       