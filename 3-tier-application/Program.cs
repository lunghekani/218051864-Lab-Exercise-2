using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;

namespace _3_tier_application
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the new class 

            var objBS = new clsBusinessLayer();

            foreach (var item in objBS.ReadEachLineSolo())
            {
                Console.WriteLine(item);
            }

        }
    }
}
