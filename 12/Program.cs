using System;
using System.Collections.Generic;
using System.Text;

namespace _12
{
    /*
    Program replaces the forbidden words with asterisks. 
    Sample text:     My name is Robertas, and i came from Lithuania
    Fobidden words : My, Robertas, came, from
    Result:          ** name is ******** , and  i **** **** Lithuania
    */

    class Program
    {
        static void Main(string[] args)
        {
            string text = "My name is Robertas, and i came from Lithuania";
            var forbiddenWords = new List<string> { "My","Robertas","came","from" };


            StringBuilder finalString = new StringBuilder(text);

            for (int i = 0; i < forbiddenWords.Count; i++)
            {
                finalString.Replace(forbiddenWords[i], "".PadRight(forbiddenWords[i].Length, '*'));
            }

            finalString.ToString();

            Console.WriteLine(text);
            Console.WriteLine(finalString);
            Console.WriteLine();
            Console.WriteLine("Forbidden words: ");
            foreach (string word in forbiddenWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
