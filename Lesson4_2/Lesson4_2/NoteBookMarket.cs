using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    interface INoteBook
    {
        public string Model { get; set; }
        public string SubModel { get; set; }
        public int Id { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public void FirstAAcceleration();
        public void SecondAcceleration(int t) 
        {
            Console.WriteLine(t);
        }
    }
}
