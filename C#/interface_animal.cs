//Create an interface IAnimal with a method MakeSound().
//Implement classes Dog and Cat that implement IAnimal. Each class should have a different
//implementation of the MakeSound method.
//Demonstrate polymorphism by creating an array of IAnimal objects and calling the MakeSound method on each.
using System;
using System.Xml.Serialization;

namespace program
{
    interface Animal
    {
        string MakeSound();
    }
    class dog : Animal
    {
        public string MakeSound()
        {
            return " dog barks : bho bho ";
        }
    }
    class cat : Animal
    {
        public string MakeSound()
        {
            return " cat meows :  meao meao ";
        }
    }
    class program
    {
        static void Main()
        {
            Animal a = new dog();
            string str = a.MakeSound();
            Console.WriteLine(str);
            Animal a1 = new cat();
            string res = a1.MakeSound();
            Console.WriteLine(res);
            
        }
    }
}