using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLogger
{
    class LogEntry
    {
        public LogEntry()
        {
            new LogEntry() { Level = LogLevel.Info };
        }

        //public class LogLevel //subclass
        //{
        //    public const string INFO = "INFO";
        //    public const string ERROR = "ERROR";
        //}
        

        public enum LogLevel { Info, Warning, Error } //tipo di oggetto composto da valori discreti

        public LogLevel Level { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public Exception Error { get; set; }
    }
}
