using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson4_2
{
    struct Str
    {
        private int Akord;
        private int Bkord;
        private int Mykord;
        public int MySumKord { get { return Mykord = Bkord+Akord; } set { Mykord = value; } }
        public Str(int akord,int bkord)
        {
            Akord = akord;
            Bkord = bkord;
            Console.WriteLine(MySumKord);
        }
    }
}
