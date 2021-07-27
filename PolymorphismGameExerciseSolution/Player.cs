using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    public class Player : GameCharacter
    {
        const int PlayerMoveUnit = 3;

        public Player(int x, int y) : base(100, x, y)
        {
        }

        public override void MoveUp()
        {
            this.Y -= PlayerMoveUnit;
        }

        public override void MoveDown()
        {
            this.Y += PlayerMoveUnit;
        }

        public override void MoveLeft()
        {
            this.X -= PlayerMoveUnit;
        }

        public override void MoveRight()
        {
            this.X += PlayerMoveUnit;
        }

        public void PowerUp(int health)
        {
            this.Health += health;
        }
    }
}
