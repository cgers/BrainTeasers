using System.Linq;

namespace BrainTeasers.Examples._001palindromes
{
    /// <summary>
    /// A palindrome is a word, number, phrase,
    /// or other sequence of characters which
    /// reads the same backward as forward,
    /// such as madam, racecar.
    /// </summary>
    public static class Palindrome
    {
        public static bool IsPalindrome(string anyWord)
        {
            char[] letters = anyWord.Trim().ToLower().ToCharArray();
            int letterCount = letters.Count();
            if (letterCount > 0)
            {
                int backwardIndex = letterCount - 1;
                for (int forwardIndex = 0; forwardIndex < letterCount; forwardIndex++)
                {
                    if (!letters[forwardIndex].Equals(letters[backwardIndex]))
                    {
                        return false;
                    }
                    backwardIndex += -1;
                }
                return true;
            }
            return false;
        }

    }
}
