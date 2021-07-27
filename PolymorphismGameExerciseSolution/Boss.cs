using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    public class Boss : Enemy
    {
        const int BossMoveUnit = 5;

        public Boss(int x, int y) : base(200, x, y)
        {
        }

        public override void MoveUp()
        {
            this.Y -= BossMoveUnit;
        }

        public override void MoveDown()
        {
            this.Y += BossMoveUnit;
        }

        public override void MoveLeft()
        {
            this.X -= BossMoveUnit;
        }

        public override void MoveRight()
        {
            this.X += BossMoveUnit;
        }
    }
}
