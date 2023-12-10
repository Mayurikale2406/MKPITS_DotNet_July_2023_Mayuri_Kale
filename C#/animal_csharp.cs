//Question: Design a class hierarchy for a zoo simulation in C#.
//Consider having base classes for animals, such as Mammal, Reptile, and Bird.
//Implement specific derived classes for animals like Lion, Snake, and Eagle.
//Each animal should have common properties like Name, Age, and a method for
//making a sound. Additionally, implement methods or properties specific to
//each animal type. Create instances of these classes and demonstrate
//polymorphism by calling the common methods on objects of different derived
//classes.
using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace program
{
    class Animal
    {
        string name { get; set; }
        int age { get; set; }
        public Animal(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void Makesound()
      
        {
            Console.WriteLine("animal sound");
        }
    }
    class Mammal:Animal
    {
        public Mammal(string name,int age) : base(name,age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("mammal sound");
        }
    }
    class Raptile : Animal
    {
        public Raptile (string name,int age):base(name,age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("raptile sound");
        }

    }
    class Bird : Animal
    {
        public Bird (string name,int age) : base(name,age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("bird sound");
        }
    }
    class Lion:Mammal
    {
        public Lion (string name,int age) : base(name,age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("Lion sound");
        }
    }
    class Snake:Raptile
    {
        public Snake(string name,int age):base(name,age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("Snake sound");
        }
    }
    class Eagle:Bird
    {
        public Eagle(string name,int age):base(name,age)
        {

        }
        public override void Makesound()
        {
            Console.WriteLine("Eagle sound");
        }
    }
    class program
    {
        static void Main()
        {
         
            Animal m = new Lion("lion", 12);
            m.Makesound();
            Animal m1 = new Snake("snake", 11);
            m1.Makesound();
            Animal m2 = new Bird("Eagle", 13);
            m2.Makesound();
            
            
            
            

        }
    }
        
}
 