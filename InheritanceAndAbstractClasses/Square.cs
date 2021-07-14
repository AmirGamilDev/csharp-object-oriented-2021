using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstractClasses
{
    public class Square : Shape
    {
        public decimal Length { get; set; }
        public override decimal Area { get => Length * Length; }

        // code above is equivalent to
        //public override decimal Area { 
        //    get
        //    {
        //        return Length * Length;
        //    }
        //}

        public Square(string colour, decimal length) : base(colour)
        {
            this.Length = length;
        }
    }
}
