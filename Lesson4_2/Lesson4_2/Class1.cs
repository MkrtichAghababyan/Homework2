using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    class SomeonesNote : Animal, INoteBook
    {
        public string Model { get; set; } = "s";
        public string SubModel { get; set; }
        public int Id { get; set; }
        public double Weight { get; set; }
        public byte Ram { get; set; }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void FirstAAcceleration()
        {
            throw new NotImplementedException();
        }

        void INoteBook.SecondAcceleration(int t)
        {
            
        }
    }
}
