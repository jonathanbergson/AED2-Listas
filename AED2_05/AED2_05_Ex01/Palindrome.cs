using System;

namespace AED2_05_Ex01
{
    internal static class Palindrome
    {
        public static void Check(string word)
        {
            Stack stack = new Stack();
            bool isPalindrome = true;

            foreach (var letter in word)
            {
                stack.Add(letter);
            }

            foreach (var letter in word)
            {
                char currentLetter = char.ToLower(letter);
                char stackLetter = char.ToLower(stack.Remove());
                if (currentLetter == stackLetter) continue;

                isPalindrome = false;
                break;
            }

            Console.WriteLine($"\tA palavra '{word}' \t\té um palíndromo? {isPalindrome}.");
        }
    }
}
