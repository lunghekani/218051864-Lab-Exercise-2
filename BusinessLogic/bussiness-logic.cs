using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace BusinessLogic //218051864 LV Langa
{
    [Serializable()]
    public class Class1
    {
    }
    
    public class clsBusinessLayer
    {
        clsDataLayer oopData = new clsDataLayer();
        public List<List<string>> ReadEachLine(){
            var stream = oopData.CreateLink();

            
            // creating a set of lists that will allow me to grab bits of Data inside the file
            List<string> lstRegion = new List<string>();
            List<string> lstCountry = new List<string>();
            List<string> lstItemType = new List<string>();
            List<string> lstSalesChannel = new List<string>();
            List<string> lstOrderPriority = new List<string>();
            List<string> lstOrderDates = new List<string>();
            // creating a list of lists to export the results as an ordered set
            List<List<string>> OrderedSets = new List<List<string>>();

            // cycling through the csv file
            while (!stream.EndOfStream)
            {
                var line = stream.ReadLine();
                var val = line.Split(','); // extracting the meaningful data with the , as a delimeter
                
                // this block and the ones to follow allow us to grab the unique sets of data and have them ordered
                if (lstRegion.Contains(val[0]))
                {
                }
                else
                {
                    lstRegion.Add(val[0]);
                }

                if (lstCountry.Contains(val[1]))
                {
                }
                else
                {
                    lstCountry.Add(val[1]);
                }

                if (lstItemType.Contains(val[2]))
                {
                }
                else
                {
                    lstItemType.Add(val[2]);
                }

                if (lstSalesChannel.Contains(val[3]))
                {
                }
                else
                {
                    lstSalesChannel.Add(val[3]);
                }

                if (lstOrderPriority.Contains(val[4]))
                {
                }
                else
                {
                    lstOrderPriority.Add(val[4]);
                }

                if (lstOrderDates.Contains(val[5]))
                {
                }
                else
                {
                    lstOrderDates.Add(val[5]);
                }
            }


            // adding the lists with the unique data to the list of lists where created earlier
            OrderedSets.Add(lstRegion);
            OrderedSets.Add(lstCountry);
            OrderedSets.Add(lstItemType);
            OrderedSets.Add(lstSalesChannel);
            OrderedSets.Add(lstOrderPriority);
            //OrderedSets.Add(lstOrderDates);
            
            // sending the ordered sets to the presentation layer to be displayed to the user
            return OrderedSets;

        }

    }
}
