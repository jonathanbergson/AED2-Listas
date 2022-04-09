using System;

namespace AED2_05_Ex01
{
    class Palindrome
    {
        public static bool Check(string word)
        {
            Pile pile = new Pile();
            bool isPalindrome = true;

            for (int i = 0; i < word.Length; i++)
            {
                pile.Add(word[i]);
            }

            for (int i = 0; i < word.Length; i++)
            {
                char lastWord = pile.Remove();
                if (Char.ToLower(word[i]) != Char.ToLower(lastWord))
                {
                    isPalindrome = false;
                }
            }

            Console.WriteLine($"\tA palavra '{word}' \t\té um palíndromo? {isPalindrome}.");

            return isPalindrome;
        }
    }
}
