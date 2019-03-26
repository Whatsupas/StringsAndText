using System;
using System.Text.RegularExpressions;

namespace _2
{
    /*
    Program extracts all e-mail addresses from a text. 
    */
    class Program
    {
        static void Main(string[] args)
        {
            string strRegex = @"[.A-Za-z0-9_\-\+]+@[A-Za-z0-9\-]+\.([A-Za-z]{2,3})(?:\.[a-z]{2})?";
            Regex myRegex = new Regex(strRegex, RegexOptions.None);
            string text = "Please contact us by phone (+47 4545 45 111) or by email at justtogo@gmail.com or at give.me@yahoo.co.uk.This is not email: test @test. This also: @gmail.com.And this: a @a.b.";

            foreach (Match myMatch in myRegex.Matches(text))
            {
                if (myMatch.Success)
                {
                    Console.WriteLine(myMatch);
                }
            }

        }
    }
}
