using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //runPart1A();

            //runPart1B();

            runPart2();
        }

        private static void runPart2()
        {
            SortedList<string, int> scores = new SortedList<string, int>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter player name for player number {i + 1}");
                string name = Console.ReadLine();

                Console.WriteLine($"Please enter player score for player number {i + 1}");
                int score = int.Parse(Console.ReadLine());

                scores.Add(name, score);
            }

            Console.WriteLine("Player scores:");

            foreach(KeyValuePair<string, int> playerScoreEntry in scores)
            {
                Console.WriteLine($"{playerScoreEntry.Key}: {playerScoreEntry.Value}");
            }
        }

        private static void runPart1B()
        {
            List<string> words = new List<string>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter word {i + 1}:");
                string word = Console.ReadLine();
                words.Add(word);
            }

            words.Sort();

            Console.WriteLine("\nAlphabetically sorted:\n\n");

            foreach(string w in words)
            {
                Console.WriteLine(w);
            }

            Console.WriteLine("Please enter word to search for:");
            string wordToSearchFor = Console.ReadLine();

            int index = words.BinarySearch(wordToSearchFor);

            if(index < 0)
            {
                Console.WriteLine($"{wordToSearchFor} is not in the list");
            }
            else
            {
                Console.WriteLine($"{wordToSearchFor} found at index {index}");
            }

        }

        private static void runPart1A()
        {
            List<int> numbers = new List<int>();

            for (int i = 1; i <= 10; i++)
            {
                numbers.Add(i);
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
