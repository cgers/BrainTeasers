using System;
using BrainTeasers.Examples._001palindromes;

namespace BrainTeasers
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Palindrome Test
            Console.WriteLine("Palindrome examples:");
            string[] words = new string[] { "Madam", "Racecar", "Palindrome", "", "A", "101" };
            
            foreach (var word in words)
            {
                Console.WriteLine("The word '{0}' is a palindrome: {1}.",
                    word,
                    Palindrome.IsPalindrome(word).ToString());
            }

            Console.WriteLine("Hit any key to exit.");
            Console.ReadLine();
        }
    }
}
