using System;
using System.IO;

namespace CSharpIntermediate_Interfaces
{
    class FileLogger : ILogger
    {
        enum MessageType
        {
            INFO,
            ERROR
        }

        readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogInfo(string message)
        {
            Log(MessageType.INFO, message);
        }

        public void LogError(string message)
        {
            Log(MessageType.ERROR, message);
        }

        private void Log(MessageType messageType, string message)
        {
            using (StreamWriter streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + " " + message);
            }
        }

    }
}
