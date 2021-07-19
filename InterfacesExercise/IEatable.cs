using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    public interface IEatable
    {
        int Calories { get; }

        void MakeSoundWhenEaten();
    }
}
