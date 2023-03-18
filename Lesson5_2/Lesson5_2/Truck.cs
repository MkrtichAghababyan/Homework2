using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson5_2.ITransport;

namespace Lesson5_2
{
    class Truck : Properties, ITransport
    {
        public string Type { get; set; } = "Truck";
        public string ShipTime { get; set; } = "2 amis";
        public override int MaxWeight { get; set; } = 100;
        public override int MinWeight { get; set; } = 1;
        public override string[] Countries { get; set; } = { "America","Mexika" };
        public bool checkweight;
        public Truck(double weight,string country)
        {
            Check(weight,ref checkweight);
            for(int i =0;i<Countries.Length;i++)
            {
                if (Countries[i] == country)
                {
                    Console.WriteLine("Its restricted area");
                    break;
                }
            }
            if (checkweight == true)
            {
                Console.WriteLine("You can use Truck");
            }
        }
   

       }
}