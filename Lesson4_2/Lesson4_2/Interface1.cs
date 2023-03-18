using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    interface ICountry
    {
        public int Population { get; set; }
        public string Name { get; set; }
        public double Size { get; set; }
        public short CreationDate { get; set; }

    }
}
