using System;

namespace RNGCryptoServiceProvider1
{
    internal class Encrypter
    {
        private static readonly char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

        public static string Encrypt(string message)
        {
            char[] secretMessage = message.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char currentChar = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, currentChar);

                // Modulus Operator and remainder of after an integer division (not to self mostly)
                int shiftedletterPosition = (letterPosition += 1) % alphabet.Length;

                //this one assigns the value after it has been shifted
                encryptedMessage[i] = alphabet[shiftedletterPosition];
            }
            return new string(encryptedMessage);
        }


        public static string Dencrypt(string demessage)
        {
            char[] secretMessage = demessage.ToCharArray();
            char[] decryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char currentChar = secretMessage[i];
                int letterPosition = Array.IndexOf(alphabet, currentChar);

                // Modulus Operator and remainder of after an integer division (not to self mostly)
                int shiftedletterPosition = (letterPosition += -1) % alphabet.Length;

                //this one assigns the value after it has been shifted
                decryptedMessage[i] = alphabet[shiftedletterPosition];
            }
            return new string(decryptedMessage);
        }


    }
}


