//Create an interface named ILogger with two methods: LogMessage(string message) and LogError(string errorMessage).
//Implement a class called ConsoleLogger that implements the ILogger interface and prints messages and errors
//to the console.Multiple Interfaces:
using System;
namespace program
{
    interface Logger
    {
        string Logmessage(string message);
        string Logerror(string errrormesssage);
        
    }
    class consolelogger : Logger
    {
        public string Logmessage(string message)
        {
            
            return "message : " + message;
        }
        public string Logerror(string errormessage)
        {
           
            return "error : " + errormessage;
        }
    }
    class program
    {
        static void Main()
        {
            consolelogger l = new consolelogger();
            string res = l.Logmessage("message");
            string res1 = l.Logerror("error message");
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.ReadKey();
            
        }
    }
}