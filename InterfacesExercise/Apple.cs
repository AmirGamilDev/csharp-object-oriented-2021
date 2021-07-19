using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    public class Apple : IEatable
    {
        public int Calories { get { return 65; } 
        }

        public void MakeSoundWhenEaten()
        {
            Console.WriteLine("Loud crunch");
        }
    }
}
