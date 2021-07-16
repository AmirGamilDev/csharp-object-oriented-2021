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

            //runPart2();

            //runPart3A();

            runPart3B();
        }

        private static void runPart3B()
        {
            Queue<Player> players = new Queue<Player>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter name for player {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Please enter score for player {i + 1}:");
                int score = int.Parse(Console.ReadLine());

                Player player = new Player(name, score);

                players.Enqueue(player);
            }

            Console.WriteLine("\n\n");

            double total = 0;
            int count = players.Count;
            int counter = 1;

            while(players.Count > 0)
            {
                Player player = players.Dequeue();

                total += player.Score;

                Console.WriteLine($"Player {counter++}:\nPlayer Name: {player.Name}\nPlayer Score: {player.Score}\n");
            }

            double average = total / count;
            Console.WriteLine($"Average Score: {average}");
        }

        private static void runPart3A()
        {
            Stack<Item> items = new Stack<Item>();

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Please enter name for item {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Please enter price for item {i + 1}:");
                decimal price = decimal.Parse(Console.ReadLine());

                Item item = new Item(name, price);

                items.Push(item);
            }

            Console.WriteLine("\n\n");

            while(items.Count > 0)
            {
                Item currentItem = items.Pop();

                decimal vatPrice = CalculateItemVatPrice(currentItem);

                Console.WriteLine($"Item: {currentItem.Name}\nPrice: {currentItem.Price}\nTotal Price: {vatPrice}");
            }
        }

        private static decimal CalculateItemVatPrice(Item item)
        {
            return item.Price * 1.23M;
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
