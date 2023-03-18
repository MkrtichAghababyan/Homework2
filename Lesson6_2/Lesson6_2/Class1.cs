using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    internal class Class1
    {
        public delegate void Del(int x);
        public delegate void Che(int x);
        public void Check1(int x)
        {
            if (x > 10 && x < 100)
            {
                Console.WriteLine("patkanum e Check1");
            }
            else
            {
                Console.WriteLine("chi patkanum Check1");
            }
        }
    }
}