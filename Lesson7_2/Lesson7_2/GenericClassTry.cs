using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_2
{
    class Gen<T>
    {
        public T Check( T a,ref bool check)
        {
            string? s = a.GetType().Name;
            if (s == "String" && string.IsNullOrEmpty(s)==true)
            {
                check = true;
            }
            else
            {
                check = false;
            }
            return a;
        }
        public T Check1(T b,ref bool check)
        {
            string s = b.GetType().Name;
            if (s == "String" && string.IsNullOrEmpty(s) == true)
            {
                check = true;
            }
            else
            {
                check = false;  
            }
            return b;
        }
       
    }
}
    
