using System;
using System.IO;



namespace Logger
{
    public class FileLogger : SampleLogger
    {
        private const string Path = @"C:\filelogger.txt";
        
        public void Log(int level, string msg)
        {
            if (!File.Exists(Path))
            {

                File.WriteAllText(Path, base.Log(level, msg));
            }
            else if (File.Exists(Path))
            {
                File.AppendAllText(Path, base.Log(level, msg));
            }
        }
    }
}
