using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonTry
{
    public class Student
    {
        public string name
        {
            get;
            set;
        }
    }
    public class Universities
    {
        public string university
        {
            get;
            set;
        }
        public IList<Student> students
        {
            get;
            set;
        }
    }
    public class ClassUniversities
    {
        public Universities universities
        {
            get;
            set;
        }
    }
}
