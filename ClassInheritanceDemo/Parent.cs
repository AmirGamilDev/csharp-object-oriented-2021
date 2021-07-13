using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceDemo
{
    public class Parent
    {
        public string Name { get; set; }

        public Parent(string name)
        {
            this.Name = name;
        }

        public virtual void PrintName()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
