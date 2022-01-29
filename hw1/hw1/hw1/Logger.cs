using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
   public class Logger
    {
        private static readonly Logger _instance = new Logger();
        private StringBuilder _logs;

        static Logger()
        {
        }

        private Logger()
        {
            _logs = new StringBuilder();
        }

        public enum LogType
        {
            Info = 1,
            Warning,
            Error
        }

        public static Logger Instance
        {
            get => _instance;
        }

        public StringBuilder ReturnValuesToFile()
        {
            return _logs;
        }

        public void Print(LogType type, string message)
        {
            var log = $"{DateTime.UtcNow}: {type.ToString()}: {message}";
            _logs.AppendLine(log);
            Console.WriteLine(log);
        }
    }
}
