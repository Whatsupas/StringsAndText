using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    /*
    Program extracts all the text without any tags and attribute values from an HTML document.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string htmlText = @"<html><head><title>News</title></head><body><p><a href=""http://softuni.org"">Software University</a>aims to provide free real-world practical training for young people who want to turn into skillful software engineers.</p></body></html>";
            StringBuilder textBuilder = new StringBuilder();

            for (int i = 0; i < htmlText.Length; i++)
            {
                if (htmlText[i] == '>' && htmlText.IndexOf('<', i) > (i + 1))
                {
                    textBuilder.Append(htmlText.Substring(i + 1, htmlText.IndexOf('<', i) - i - 1));
                    textBuilder.Append(" ");
                }
            }

            string finalText = textBuilder.ToString().TrimEnd();
            Console.WriteLine(finalText);
        }
    }
}
