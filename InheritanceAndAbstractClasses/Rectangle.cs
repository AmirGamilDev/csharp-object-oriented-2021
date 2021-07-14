using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Rectangle : Shape
    {
        public decimal Length { get; set; }
        public decimal Width { get; set; }
        public override decimal Area { get => Length * Width; }

        public Rectangle(string colour, decimal length, decimal width) : base(colour)
        {
            this.Length = length;
            this.Width = width;
        }
    }
}
