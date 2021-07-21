using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yourFavoriteThings.Things
{
    class Book
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public void Read()
        {
            Console.WriteLine($"{Name} is a work of {Type}.");
        }

        public void Write()
        {
            Console.WriteLine($"{Name} is an {Type} who I enjoy.");
        }
    }
}
