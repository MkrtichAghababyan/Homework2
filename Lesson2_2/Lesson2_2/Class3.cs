using System;
namespace Lesson2_2
{
    internal class DrAssist:Doctor
    {
        public void DoctAss()
        {
            Console.WriteLine(Name);
        }
        public int AsistantAge { get; set; }
        public DrAssist()
        {

        }
    }
}
