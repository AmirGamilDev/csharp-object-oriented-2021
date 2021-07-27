using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    public class Ship : IMoveable
    {
        const int ShipMoveUnit = 10;

        // implements public getters for X and Y but only private setters
        // to allow Ship class to set its coorindates but not allow other
        // classes to set the coordinates of the ship (position should be
        // affected only by using the Move methods)
        public int X { get; private set; }
        public int Y { get; private set; }

        public Ship(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void MoveUp()
        {
            this.Y -= ShipMoveUnit;
        }

        public void MoveDown()
        {
            this.Y += ShipMoveUnit;
        }

        public void MoveLeft()
        {
            this.X -= ShipMoveUnit;
        }

        public void MoveRight()
        {
            this.X += ShipMoveUnit;
        }
    }
}
