using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5_2
{
    abstract class Properties
    {
        //shiptime motavor jam double
        //trackid hamary
        //shipcoas giny 
        //sksman or avartman or 
        public abstract int MinWeight { get; set; }
        public abstract int MaxWeight { get; set; }
        public abstract string[] Countries { get; set; }
        public void Check(double weight,ref bool b)
        {
            if (weight < MinWeight)
            {
                Console.WriteLine("Your Weight Is Too Low");
            }
            else if (weight > MaxWeight)
            {
                Console.WriteLine("Your Weight Is Too Large");
            }
            else 
            {
                b=true;  
            }
        }
    }
}
