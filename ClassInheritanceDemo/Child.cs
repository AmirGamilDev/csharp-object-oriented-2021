using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceDemo
{
    public class Child : Parent
    {
        public string FavouriteToy { get; set; }

        public Child(string name, string favouriteToy) : base(name)
        {
            this.FavouriteToy = favouriteToy;
        }

        public override void PrintName()
        {
            Console.WriteLine($"Child name: {Name}");
        }
    }
}
