using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


namespace BusinessLogic
{
    public class Class1
    {
    }

    public class clsBusinessLayer
    {
        clsDataLayer oopData = new clsDataLayer();
        public List<string> ReadEachLineSolo(){
            return oopData.CreateLink();

        }
    
    }
}
