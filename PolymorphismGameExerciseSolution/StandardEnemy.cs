using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    public class StandardEnemy : Enemy
    {
        const int StandardEnemyMoveUnit = 2;

        public StandardEnemy(int x, int y) : base(30, x, y)
        {
        }

        public override void MoveUp()
        {
            this.Y -= StandardEnemyMoveUnit;
        }

        public override void MoveDown()
        {
            this.Y += StandardEnemyMoveUnit;
        }

        public override void MoveLeft()
        {
            this.X -= StandardEnemyMoveUnit;
        }

        public override void MoveRight()
        {
            this.X += StandardEnemyMoveUnit;
        }
    }
}
