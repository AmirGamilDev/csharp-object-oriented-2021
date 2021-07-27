using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    public interface IMoveable
    {
        // define only that a class that implements the IMoveable interface
        // have getters for the X and Y coorindates (classes can decide their own
        // setter if they wish - see comments in GameCharacter and Ship classes)
        int X { get; }
        int Y { get; }

        void MoveUp();
        void MoveDown();
        void MoveLeft();
        void MoveRight();
    }
}
