using System;

namespace CSharpIntermediate_Interfaces
{
    class ConsoleLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Log(message, ConsoleColor.Green);
        }

        public void LogError(string message)
        {
            Log(message, ConsoleColor.Red);
        }

        private void Log(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
        }
    }
}
