using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    internal class VirtualMeth
    {
        public virtual string Name { get; set; }
        public void NormMeth()
        {
            Console.WriteLine("Normal Method");
        }
        public virtual int VirtMeth(string s)
        {
            return 0;
        }
        public virtual void VirtcVoidMeth()
        {
            Console.WriteLine("Virtual Meth");
        }
        public virtual void VirtcEmptyVoidMeth()
        {

        }
    }
}
