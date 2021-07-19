using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Bird : Animal, IFlyer
    {
        public Bird(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Tweet!");
        }

        public void Fly()
        {
            Console.WriteLine("Flap flap flap");
        }
    }
}
