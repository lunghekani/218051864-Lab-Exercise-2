using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace _3_tier_application //218051864 LV Langa
{
    class presentation
    {
        static void Main(string[] args)
        {

            var objBS = new clsBusinessLayer();

            var finalSets = objBS.ReadEachLine();
            foreach (List<string> subList in finalSets) //cycle through the ordered set of lists 
            {
                // cycle through each sublist item inside of the ordered sets
                foreach (string item in subList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine("==================================");
                Console.WriteLine();
                
            }

            Console.ReadLine();
        }
    }
}
