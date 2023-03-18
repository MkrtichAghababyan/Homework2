using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_2
{
    internal class Country : ICountry
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public double Size { get; set; }
        public short CreationDate { get; set; }

        public Country(string name, int pop, double size, short creat)
        {
            Name = name;
            Console.WriteLine($"The Name Of Your Country Is {Name}");
            Population = pop;
            Console.WriteLine($"The Population Of Your Country Is {Population}");
            Size = size;
            Console.WriteLine($"The Size Of Your Country Is {Size}km2");
            CreationDate = creat;
            Console.WriteLine($"The Creation Date Of Your Country Is {CreationDate}");
        }

    }
    abstract class Animal
    {
        abstract public string Name { get; set; }

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
        public void About() 
        {
            Console.WriteLine();
        }
        public void Sle1ep()
        {
            Console.WriteLine("Zzz");
        }
        public void Abou1t()
        {
            Console.WriteLine();
        }
    }
}
