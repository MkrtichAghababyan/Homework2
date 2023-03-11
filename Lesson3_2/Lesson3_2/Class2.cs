using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    internal class Class2:VirtualMeth
    {
        public override void VirtcEmptyVoidMeth()
        {
            base.NormMeth();
            Console.WriteLine(" Class2:VirtualMeth");
        }
        public override int VirtMeth(string s) 
        {
            return base.VirtMeth(s);
        }
    }
}
