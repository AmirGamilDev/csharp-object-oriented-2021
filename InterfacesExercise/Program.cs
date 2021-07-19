using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple = new Apple();
            Banana banana = new Banana();
            Crunchie crunchie = new Crunchie();

            Console.WriteLine($"Apple Calories: {apple.Calories}");
            Console.WriteLine("Apple sound:");
            apple.MakeSoundWhenEaten();

            Console.WriteLine();

            Console.WriteLine($"Banana Calories: {banana.Calories}");
            Console.WriteLine("Banana sound:");
            banana.MakeSoundWhenEaten();

            Console.WriteLine();

            Console.WriteLine($"Crunchie Calories: {crunchie.Calories}");
            Console.WriteLine("Crunchie sound:");
            crunchie.MakeSoundWhenEaten();
        }
    }
}
