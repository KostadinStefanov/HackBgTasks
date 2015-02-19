using System;
using System.Collections.Generic;



namespace Logger
{
    public abstract class SampleLogger : ILogger
    {
        private static readonly Dictionary<int, string> levels = new Dictionary<int, String>()
        {
            { 1, "INFO" },
            { 2, "WARNING" },
            { 3, "PLSCHECKFFS" } 
        };

        public string Datetime
        {
            get { return DateTime.UtcNow.ToString("s", System.Globalization.CultureInfo.InvariantCulture); }
        }

        public virtual string Log(int level, string msg)
        {
            return String.Format(
                "{0}::{1}::{2}",
              levels[level], this.Datetime, msg);
        }
    }
}
