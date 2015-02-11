using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class LoggerTest
    {
        public static void Main()
        {
            var consoleLogger = new ConsoleLogger();
            consoleLogger.Log(2, "Hack BG Warning Test");
            
            var fileLogger = new FileLogger();
            fileLogger.Log(1, "Hack BG Info Test");
            
            
        }
    }
}
