using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DataAccess
{
    public class Class1
    {
    }

    public class clsDataLayer
    {
        public List<string> CreateLink() {
            var stream = new StreamReader(@"../../financial-year.csv");
            List<string> lstLines = new List<string>();
            
            while (!stream.EndOfStream)
            {
                var line = stream.ReadLine();
                lstLines.Add(line);
            
            }

            return lstLines;
        }

    }

}
