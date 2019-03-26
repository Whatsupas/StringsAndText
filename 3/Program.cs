using System;

namespace _3
{
    /*
     Program extracts from a text all words 
     which are palindromes, such as "ABBA", "lamal", "exe".
     */
    class Program
    {
        static void Main(string[] args)
        {
            string text = "abba is the best music band in the world since 1980. Wow Is that true ? Download our eXe file to improve your music knowledges\n";
            string[] array = text.Split(' ');

            Console.WriteLine(text);
            Console.WriteLine("Palindromes words:\n");

            for (int i = 0; i < array.Length; i++)
            {
                if (IsPailindromes(array[i]))
                    Console.WriteLine(array[i]);
            }

        }
        static bool IsPailindromes(string word)
        {
            int length = word.Length;
            bool result = false;

            switch (length)
            {
                case 0:
                case 1:
                case 2:
                    return result;
                default:
                    for (int i = 0; i < length / 2; i++)
                    {
                        if (char.ToUpper(word[i]) != char.ToUpper(word[word.Length - 1 - i]) &&
                            char.ToUpper(word[i]) != char.ToLower(word[word.Length - 1 - i]))
                        {
                            return result;
                        }
                    }
                    break;
            }
            result = true;
            return result;
        }
    }
}
