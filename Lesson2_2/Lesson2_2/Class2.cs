using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2
{
    internal class Doctor:Humen
    {
        public Doctor():base()
        {       
        }
        public Doctor(int t):base(t)
        {   
        }
        public Doctor(int t, GenderEnum gender) : base(t, gender) { Console.WriteLine("doctor"); }
        public void TestMeth()
        {
            //Name="Eliz";
            Age = 120;
            HelloMen();
        }
    }
}
