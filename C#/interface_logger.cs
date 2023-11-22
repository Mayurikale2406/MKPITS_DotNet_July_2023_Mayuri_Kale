//Extend the ILogger interface from the first question by adding a default method LogInfo(string infoMessage)
//that logs informational messages.//Implement the ConsoleLogger class to support the new LogInfo method.
//Interface Inheritance:
using System;
namespace program
{
    interface Logger
    {
        string Logmessage(string message);
        string Logerror(string errrormesssage);
        string LogInfo(string infomessage);

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
        public string LogInfo(string infomessage)
        {
            return " loginfo : " + infomessage;
        }
    }
    class program
    {
        static void Main()
        {
            consolelogger l = new consolelogger();
            string res = l.Logmessage("message");
            string res1 = l.Logerror("error message");
            string res2 = l.LogInfo("info message");
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.ReadKey();

        }
    }
}