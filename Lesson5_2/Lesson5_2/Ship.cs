using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_2
{
    class Ship:Properties,ITransport
    {

        public string Type { get; set; } = "Truck";
        public string ShipTime { get; set; } = "2 amis";
        public override int MaxWeight { get; set; } = 100;
        public override int MinWeight { get; set; } = 1;
        public override string[] Countries { get; set; } = { "America","Mexika" };
        public bool checkweight;
        public Ship(double weight, string country)
        {
            Check(weight, ref checkweight);
            foreach (var c in Countries)
            {
                if (c == country)
                {
                    Console.WriteLine("Its restricted area");
                }
            }
            if (checkweight == true)
            {
                Console.WriteLine("You can use Ship");
            }
        }


    }
}
