using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt_Decrypt
{
    internal class Affine
    {
        static int CalculateGcd(int a, int b)
        {
            if (a == 0)
                return 0;

            if (a == b)
                return a;

            if (a > b)
                return CalculateGcd(a - b, b);

            return CalculateGcd(a, b - a);
        }

        public static string Encipher(char[] secretMessage, int a, int b)
        {
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                if (secretMessage[i] != ' ')
                {
                    char letter = secretMessage[i];
                    char newLetter = Alphabet.alphabet[((a * Array.IndexOf(Alphabet.alphabet, letter)) + b) % 26];

                    encryptedMessage[i] = newLetter;
                }
                else
                {
                    encryptedMessage[i] = secretMessage[i];
                }
            }

            return new string(encryptedMessage);
        }

        public static string Decipher(char[] secretMessage, int a, int b)
        {
            char[] decryptedMessage = new char[secretMessage.Length];
            int inverseA = 0;
            int flag = 0;

            for (int i = 0; i < 26; i++)
            {
                flag = (a * i) % 26;

                if (flag == 1)
                {
                    inverseA = i;
                }
            }

            for (int i = 0; i < secretMessage.Length; i++)
            {
                if (secretMessage[i] != ' ')
                {
                    char letter = secretMessage[i];
                    char newLetter = Alphabet.alphabet[inverseA * ((Array.IndexOf(Alphabet.alphabet, letter) + 26) - b) % 26];

                    decryptedMessage[i] = newLetter;
                }
                else
                {
                    decryptedMessage[i] = secretMessage[i];
                }
            }

            return new string(decryptedMessage);
        }
    }

    static class Alphabet
    {
        public static char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
    }
    
}
