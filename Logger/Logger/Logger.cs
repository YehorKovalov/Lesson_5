using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public sealed class Logger
    {
        private static readonly Logger _instance = new Logger();

        static Logger()
        {
        }

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                return _instance;
            }
        }

        public StringBuilder Reports { get; } = new StringBuilder();

        public void Log(LogType logType, string message)
        {
            if (string.IsNullOrEmpty(message) == false)
            {
                string report = $"{DateTime.Now}:{logType}:{message}\n";
                Reports.Append(report);
                Console.Write(report);
            }
        }
    }
}
