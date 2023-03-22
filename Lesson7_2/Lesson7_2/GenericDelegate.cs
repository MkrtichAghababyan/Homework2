using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    class GenericDelegate
    {
        public delegate void Del<T>(T item); 
        public GenericDelegate()
        {
            Del<bool> del1 = new Del<bool>(Bo);
            Del<string> del = new Del<string>(Sum);
            Del<int> del2 = new Del<int>(Notify);
            del("s");
            del1(true);
            del2(1);
        }
        public void Bo(bool b) { Console.WriteLine(b); }
        public void Notify(int i) { Console.WriteLine(i); }
        public void Sum(string a) { Console.WriteLine(a); }
    }
}
