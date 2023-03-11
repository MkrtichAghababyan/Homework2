using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_2
{
    public enum GenderEnum
    {
        Boy,
        Girl,
        Them
    }
    internal class Humen
    {
        private protected string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        
        public Humen()
        {
             
        } 
        public Humen(int Age)
        {
            this.Age = Age;
        }
        public Humen(int age, GenderEnum gender)
        {
            Gender = gender;
            Age= age;
            Console.WriteLine($"age={age} gender = {gender}");
        }

        public  GenderEnum Gender { get; set; }
        /*private string Test { get; set; }*/
        public void HelloMen()
        {
            Console.WriteLine(" pub Barev Mard");
        }
        internal void ByMen()
        {
            Console.WriteLine(" inter Barev Mard");
        }
        protected void WhyMen()
        {
            Console.WriteLine("pro Barev Mard");
        }
    }
}
