using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFavoriteThings.Things
{
    class Hike
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Park()
        {
            Console.WriteLine($"{Name} is nice!");
        }

        public void DifficultyLevel(string moderate)
        {
            Console.WriteLine($"The {Name} loop is a {moderate} level of difficulty. ");
        }
    }
}
