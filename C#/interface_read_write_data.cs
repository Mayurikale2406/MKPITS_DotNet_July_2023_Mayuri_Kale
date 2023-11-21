//Design two interfaces, IReadable and IWritable, each with a method ReadData() and WriteData(string data) respectively.
//Create a class FileHandler that implements both IReadable and IWritable. Show how this class can be used to read and write data.
//Default Interface Method:
using System;
namespace program
{
    interface IReadable
    {
        string ReadData();
        string WriteData(string data);
    }
    interface IWritable
    {
        string ReadData();
        string WriteData(string data);
    }
    class FileHandler : IReadable,IWritable
    {
        public string ReadData()
        {
            return "call from readdata " ;
        }
        public string WriteData( string data)
        {
            return "call from writedata :  " + data;
        }

    }
    class program
    {
        static void Main()
        {
            IReadable r;
            FileHandler f = new FileHandler();
            string str = f.ReadData();
            Console.WriteLine(str);
            string res = f.WriteData("writedata");
            Console.WriteLine(res);

            IWritable w;
            FileHandler f1 = new FileHandler();
            string str1 = f.ReadData();
            Console.WriteLine(str1);
            string res1 =f.WriteData("writedata");
            Console.WriteLine(res);
           
            Console.ReadKey();
        }
    }
}