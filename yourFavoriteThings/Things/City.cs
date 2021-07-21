using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFavoriteThings.Things
{
    class City
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Fly() {
            Console.WriteLine($"{Name} is an {Type} city that I can fly to.");
        }

        public void Walk()
        {
            Console.WriteLine($"{Name} is a city in the French {Type}.");
        }
    }
}
