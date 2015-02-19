using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace QL_overCSVfile
{
    public class CSVreader
    {
        private static string[] allLines = File.ReadAllLines(@"D:\Temporary\data.csv");

       public static  List<CSVobject> Query()
        {
            var CSVobjects = new List<CSVobject>();
            foreach (string line in allLines)
            {
                string[] data = line.Split(',');
                var result = new CSVobject
                {
                    ID = Convert.ToInt16(data[0]),
                    Name = data[1],
                    Course = data[2],
                };
                CSVobjects.Add(result);
            }
            return CSVobjects;

        } 
    }

    public class CSVobject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public override string ToString()
        {
            return String.Format(
               "|  {0}   |  {1}  |   {2}     |",
                this.ID, this.Name, this.Course);

        }
    }
}

