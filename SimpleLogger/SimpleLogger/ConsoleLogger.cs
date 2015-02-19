using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class ConsoleLogger : SampleLogger
    {
        public void Log(int level, string msg)
        {
            Console.WriteLine(base.Log(level, msg));
        }     
    }
}
