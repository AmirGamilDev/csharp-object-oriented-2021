using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    public class Banana : IEatable
    {
        public int Calories { get => 90; }

        public void MakeSoundWhenEaten()
        {
            Console.WriteLine("Squish");
        }
    }
}
