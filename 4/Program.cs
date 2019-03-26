using System;
using System.Linq;
using System.Text;

namespace _4
{
    /*
    Program reads a string from the console and prints
    in alphabetical order all letters from the input string and how 
    many times each one of them occurs in the string.
    Data validation is not implemented
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type what you want to say:");
            string text = Console.ReadLine();

            StringBuilder textBuilder = new StringBuilder();
            char[] array = text.OrderBy(d => d).ToArray();
            textBuilder.Append(array);

            for (int i = 1; i < textBuilder.Length; i++)
            {
                if (textBuilder[i] != textBuilder[i - 1])
                {
                    textBuilder.Insert(i, "]");
                }
                else
                {
                    continue;
                }
                i++;
            }
            
            Console.WriteLine("Sorted word:");
            Console.WriteLine(array);
            Console.WriteLine();
            Console.WriteLine("Acurrence:");

            string[] masyvas = textBuilder.ToString().Split(']');

            for (int i = 0; i < masyvas.Length; i++)
            {
                Console.WriteLine(masyvas[i].Length > 1 ? "Letter {0} accurs {1} times" 
                                                        : "Letter {0} accurs {1} time", masyvas[i].First(), masyvas[i].Length);
            }
        }

    }
}
