using System;

namespace _7
{
    /*
    Program detects how many times a substring is contained in the text. 
   */
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Returns a pointer to an array that contains a null-terminated sequence of characters (i.e., a C-string) representing the current value of the string";
            string subString = "in";
            string lowerLetterstext = text.ToLower();
            int startAtIndex = 0;
            int counter = 0;

            while (lowerLetterstext.IndexOf(subString, startAtIndex) >= 0)
            {
                counter++;
                startAtIndex = lowerLetterstext.IndexOf("in", startAtIndex) + 1;
            }
            Console.WriteLine($"Substring: \"{subString}\" accurs {counter}");
        }
    }
}
