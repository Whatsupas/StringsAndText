using System;
using System.Linq;
using System.Text;

namespace _5
{
    /*
    Program reads a string from the console and replaces every sequence of identical letters in
    it with a single letter (the repeating letter). Data validation is not implemented
    Example: "aaaaabbbbbcdddeeeedssaa"
    Result: "abcdedsa".
   */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type what you want to say:");
            string text = Console.ReadLine();

            StringBuilder textBuilder = new StringBuilder();
            textBuilder.Append(text.First());
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                    textBuilder.Append(text[i]);
            }
            Console.WriteLine(textBuilder);
        }
    }
}
