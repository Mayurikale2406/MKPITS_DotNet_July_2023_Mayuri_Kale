//Create a base class called Vehicle with attributes like "make" and "model."
//Derive a class called Car from the Vehicle class, adding specific attributes like "numDoors" and "fuelType."
//Instantiate an object of the Car class and demonstrate inheritance by accessing attributes from both the base and derived classes.

using System;
namespace program
{
    public class vehicle
    {
        public int make;
        public string model;
    }
    class car: vehicle
    {
        public int numdoors;
        public string fueltype;

    }
    class program
    {
        public static void Main()
        {
            car v1 = new car();
            v1.make = 2017;
            v1.model = "mercedes";
            v1.numdoors = 4;
            v1.fueltype = "petrol";

            Console.WriteLine("make : " +v1.make);
            Console.WriteLine("model : " +v1.model);
            Console.WriteLine("number door : " + v1.numdoors);
            Console.WriteLine("fueltype : " + v1.fueltype);

            Console.ReadKey();
        }
    }
}