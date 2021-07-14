using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override decimal Area { get => (decimal)(Math.PI * Math.Pow(Radius, 2)); }

        public Circle(string colour, double radius) : base(colour)
        {
            this.Radius = radius;
        }
    }
}
