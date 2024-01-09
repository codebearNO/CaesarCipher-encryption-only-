using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to encryptoco. \n Please enter your message for encryption:");
            string answer = Console.ReadLine();

            char[] secretMessage = answer.ToCharArray();
            char[] encryptedMessage = Encrypt(secretMessage, 3);

            Console.WriteLine(encryptedMessage);
        }
        static char[] Encrypt(char[] input, int key)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] encryptedMessage = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char secret = Char.ToLower(input[i]);

                if (secret == ' ')
                {
                    encryptedMessage[i] = secret;
                    continue;
                }
                int newLetter = (Array.IndexOf(alphabet, secret) + key) % 26;
                encryptedMessage[i] = alphabet[newLetter];
            }

            return encryptedMessage;
        }
    }
}