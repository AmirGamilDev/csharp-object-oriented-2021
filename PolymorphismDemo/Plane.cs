using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    public class Plane : IFlyer
    {
        public void Fly()
        {
            Console.WriteLine("VOOOOOOOOOOOOOOOOM");
        }
    }
}
