using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace QL_overCSVfile
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var engine = new Engine();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == null || commandLine == "END")
                {
                    // End of command sequence reached
                    break;
                }
                if (commandLine != "")
                {
                    var commandTokens = commandLine.Split(new string[] { ",", " ", "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                    string cmd = commandTokens[1];                   
                    string[] cmdArgs = (commandTokens.Skip(2)).ToArray();
                    var cmdResult = engine.ExecuteCommand(cmd, cmdArgs);
                    foreach (var line in cmdResult)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
