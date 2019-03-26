using System;
using System.Text;

namespace _11
{
    /*
    Program encrypts a text by applying XOR (excluding or)
    operation between the given source characters and given cipher code.
    The encryption done by applying XOR between the first letter 
    of the text and the first letter of the code, the second letter of the text
    and the second letter of the code, etc. until the last letter of the code.
    Then goes back to the first letter of the code and the next letter of the text. 
    Printing result as a series of Unicode escape characters \xxxx.
    */
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Testing";
            string cipherCode = "abc";
            string encryptedText = Encryption(text, cipherCode);
            
            Console.WriteLine($"Text: {text}\nCiper Code: {cipherCode}\nEncrypted text: {encryptedText}");
        }

        static string Encryption(string text, string cipherCode)
        {
            int textLength = text.Length;
            string givenCode = cipherCode.PadRight(textLength);
            int startIndex = 0;

            StringBuilder fixCode = new StringBuilder();
            while (fixCode.Length < textLength)
            {
                if (givenCode[startIndex] == ' ')
                    startIndex = 0;
                else
                {
                    fixCode.Append(givenCode[startIndex]);
                    startIndex++;
                }
                
            }

            StringBuilder finalString = new StringBuilder();
            for (int i = 0; i < textLength; i++)
            {
                finalString.Append("\\u" + ((text[i]) ^ (fixCode[i])).ToString("X4"));
            }
            return finalString.ToString();
        }
    }
}
