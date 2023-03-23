using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmBoom
{
    public interface IProperties
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public string Actors { get; set; }
        public int WatchedCount { get; set; }
        public bool Stared { get; set; }
    }
}
