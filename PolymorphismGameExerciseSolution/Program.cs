using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismGameExerciseSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(50, 50);
            StandardEnemy standardEnemy = new StandardEnemy(60, 60);
            Boss boss = new Boss(70, 70);
            Ship ship = new Ship(80, 80);

            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(player);
            characters.Add(standardEnemy);
            characters.Add(boss);

            DeliverDamageToAllCharacters(characters);

            foreach(GameCharacter character in characters)
            {
                Console.WriteLine();
                PrintGameCharacterInfo(character);
                Console.WriteLine();
            }

            player.PowerUp(10);
            Console.WriteLine("After player power up");
            PrintGameCharacterInfo(player);

            List<IMoveable> moveables = new List<IMoveable>(characters);
            moveables.Add(ship);
            TestMovingTheMoveables(moveables);

            foreach(IMoveable moveable in moveables)
            {
                Console.WriteLine();
                PrintGameElementPosition(moveable);
                Console.WriteLine();
            }
        }

        private static void PrintGameCharacterInfo(GameCharacter gameCharacter)
        {
            Console.WriteLine(gameCharacter.GetType().Name);
            Console.WriteLine(gameCharacter.Health);            
        }

        private static void PrintGameElementPosition(IMoveable moveable)
        {
            Console.WriteLine(moveable.GetType().Name);
            Console.WriteLine($"X: {moveable.X}");
            Console.WriteLine($"Y: {moveable.Y}");
        }

        private static void TestMovingTheMoveables(List<IMoveable> moveables)
        {
            foreach(IMoveable moveable in moveables) {
                moveable.MoveDown();
                moveable.MoveDown();

                moveable.MoveUp();

                moveable.MoveRight();
                moveable.MoveRight();

                moveable.MoveLeft();
            }
        }

        private static void DeliverDamageToAllCharacters(List<GameCharacter> characters)
        {
            foreach(GameCharacter character in characters)
            {
                character.TakeDamage(5);
            }
        }
    }
}
