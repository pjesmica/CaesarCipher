using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Caesar
    {

        public static string Encrypt(string text, long shift)
        {
            char[] cipherText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                if (char.IsLetter(current))
                {
                    char baseL = char.IsUpper(current) ? 'A' : 'a';
                    cipherText[i] = (char)(((current + shift - baseL) % 26) + baseL);
                }
                else
                {
                    cipherText[i] = current;
                }
            }

            return new string(cipherText);
        }

        public static string Decrypt(string text, long shift)
        {
            char[] cipherText = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                char current = text[i];

                if (char.IsLetter(current))
                {
                    char baseL = char.IsUpper(current) ? 'A' : 'a';

                    cipherText[i] = (char)(((current - shift - baseL + 26) % 26) + baseL);
                }
                else
                {
                    cipherText[i] = current;
                }
            }

            return new string(cipherText);
        }

    }
}
