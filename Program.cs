using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCharacterAccess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("Error: Word cannot be empty.");
                return;
            }
            Console.Write($"Enter a position (0-{word.Length - 1}): ");
            string positionInput = Console.ReadLine();

            if (!int.TryParse(positionInput, out int position))
            {
                Console.WriteLine("Error: Position must be a number.");
                return;
            }
            if (position < 0 || position >= word.Length)
            {
                Console.WriteLine($"Error: Position must be between 0 and {word.Length - 1}.");
                return;
            }
            char character = word[position];
            Console.WriteLine($"Character at position {position}: '{character}'");
        }
    }
}
