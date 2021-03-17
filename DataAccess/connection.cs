using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DataAccess //218051864 LV Langa
{
    public class connection
    {
    }

    public class clsDataLayer
    {
        public StreamReader CreateLink() {
            var stream = new StreamReader(@"../../500000 Sales Records.csv"); // setting the connection to the CSV file
           
            return stream;
        }

    }

}
