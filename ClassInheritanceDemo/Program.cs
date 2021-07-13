using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Parent parent = new Parent("Bob");
            parent.PrintName();

            Child child = new Child("Joe", "Spinning top");
            child.PrintName();

            Parent child2 = new Child("Lenny", "Train");
            child2.PrintName();
        }
    }
}
