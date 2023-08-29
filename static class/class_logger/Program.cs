using System;

namespace class_logger
{
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("This is a log message.");
            Logger.LogMessage("Another log message.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }

}
