using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    public class Crunchie : IEatable
    {
        public int Calories => 150;

        public void MakeSoundWhenEaten()
        {
            Console.WriteLine("Light crunch");
        }
    }
}
