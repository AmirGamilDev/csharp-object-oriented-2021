using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public abstract class Shape
    {
        public string Colour { get; set; }
        public abstract decimal Area { get; }

        public Shape(string colour)
        {
            this.Colour = colour;
        }
    }
}
