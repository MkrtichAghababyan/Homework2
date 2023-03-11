using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_2
{
    internal class Animal:VoiceSpeed1
    {
        public override void VoiceSpeed(string s)
        {
            switch (s)
            {
                case "dog":
                    Console.WriteLine($"{s} make {((Animals)0)}");
                    Console.WriteLine($"{s} ran 10km/h");
                    break;
                case "cat":
                    Console.WriteLine($"{s} make {((Animals)1)}");
                    Console.WriteLine($"{s} ran 20km/h");
                    break;
            }
        }
        public Animal(string s)
        {
            switch (s)
            {
                case "dog":
                    VoiceSpeed(s);
                    break;
                case "cat":
                    VoiceSpeed(s);
                    break;
            }
        }
    }
    enum Animals
    {
        Woof,
        Myau
    }
}
