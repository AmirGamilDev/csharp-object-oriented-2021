using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    public abstract class GameCharacter : IMoveable
    {
        // Note: A better software engineering solution might have been to
        // have an IDamageable interface for more flexibility down the line.
        // Including it as part of the GameCharacter class to show only where
        // it *needs* to be.
        // This goes for both the Health property and the TakeDamage method
        // (i.e. both the property and method would have been in an IDamageable interface).
        public int Health { 
            get;
            protected set;
        }

        // implements public getters for X and Y but only protected setters
        // to allow child classes to set their coorindates but not allow other
        // classes to set the coordinates of the game characters (position should be
        // affected only by using the Move methods)
        public int X { get; protected set; }
        public int Y { get; protected set; }

        public GameCharacter(int health, int x, int y)
        {
            this.Health = health;
            this.X = x;
            this.Y = y;
        }

        public void TakeDamage(int damage)
        {
            this.Health -= damage;
        }

        public abstract void MoveUp();
        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();
    }
}
