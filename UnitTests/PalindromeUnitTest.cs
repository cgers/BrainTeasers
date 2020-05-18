using System;
using BrainTeasers.Examples.Palindrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class PalindromeUnitTest
    {
        [TestMethod]
        public void TestWords()
        {
            Console.WriteLine("Palindrome examples:");
            string[] words = new string[] { "Madam",
                                            "Racecar",
                                            "Palindrome",
                                            "",
                                            "A",
                                            "101" };

            Assert.AreEqual(Palindrome.IsPalindrome(words[0]), true);
            Assert.AreEqual(Palindrome.IsPalindrome(words[1]), true);
            Assert.AreEqual(Palindrome.IsPalindrome(words[2]), false);
            Assert.AreEqual(Palindrome.IsPalindrome(words[3]), false);
            Assert.AreEqual(Palindrome.IsPalindrome(words[4]), true);
            Assert.AreEqual(Palindrome.IsPalindrome(words[5]), true);

        }
    }
}
