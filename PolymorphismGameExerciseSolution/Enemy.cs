using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    public abstract class Enemy : GameCharacter
    {
        public Enemy(int health, int x, int y) : base(health, x, y)
        {
        }
    }
}
