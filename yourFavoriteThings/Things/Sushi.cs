using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFavoriteThings.Things
{
    class Sushi
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Eat(string restaurant)
        {
            Console.WriteLine($"The {Name} at {restaurant} is yummy.");
        }

        public void Slurp()
        {
            Console.WriteLine($"{Type} like {Name} can be noisy.");
        }
    }
}
