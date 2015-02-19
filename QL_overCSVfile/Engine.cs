using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;


namespace QL_overCSVfile
{
    class Engine
    {

        private List<CSVobject> CSVobjects;

        public Engine()
        {
             this.CSVobjects = CSVreader.Query();
        }
       

        public List<object> ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "SELECT":
                    throw new NotImplementedException();   
                case "SUM":
                    throw new NotImplementedException();
                case "SHOW":
                    return ExecuteShowCommand(cmdArgs);
                case "FIND":                   
                     return ExecuteFindCommand(cmdArgs);

                default:
                     List<object> shownobjects = new List<object>();
                     var text = String.Format("Invalid command ! only \"SELECT\" , \"SUM\" ,\"SHOW\" or \"FIND\"! -- END to EXIT ");                  
                     shownobjects.Add(text);
                    return shownobjects;
            }
        }

        private List<object> ExecuteShowCommand(string[] cmdArgs)
        {
            List<object> shownobjects = new List<object>();

            foreach (var prop in CSVobjects)
            {
                var text = String.Format("{0}, {1}, {2}", prop.ID, prop.Name, prop.Course); 
                shownobjects.Add(text);
               
            }
            return shownobjects;
        }

        private List<object> ExecuteFindCommand(string[] cmdArgs)
        {
           return Filter(CSVobjects, cmdArgs[0]) ;
        }

        
        public List<object> Filter(List<CSVobject> collection, string filterValue)
        {
            List<object> shownobjects = new List<object>();

            var filteredCollection =
            collection.Where(item => item.Name.Contains(filterValue) ||
                item.ID.ToString(CultureInfo.InvariantCulture).Contains(filterValue) ||
                item.Course.Contains(filterValue)
                ). ToList();
            var text = "|  id  | name   | hometown          |";
            shownobjects.Add(text);

            foreach (var filtered in filteredCollection)
            {
                shownobjects.Add(filtered);
            }
            
            return shownobjects;

        }


    }


}


