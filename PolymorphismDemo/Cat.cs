using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Meow!");
        }

        public void ClimbTree()
        {
            Console.WriteLine($"{Name} is climbing up a tree");
        }
    }
}
