using System;

namespace my_csharp
{
    public abstract class CryptoEx
    {
        private int shift = 3;
        // private string plaintext = "";
        // public int Shift
        // {
        //     set => shift = value;
        // }

        
        public static string Encrypt(string plainText,int shift=3)
        {
            string cipherText = "";
            for (int i = 0; i < plainText.Length; i++)
            {
                int c = (int)plainText[i];
                if (c == (int)'A')
                {
                    cipherText += "X";

                }else if (c == (int)'B')
                {
                    cipherText += "Y";
                }else if (c == (int)'C')
                {
                    cipherText += "Z";
                }
                else
                {
                    char cc = (char) (c - shift);
                    cipherText += cc.ToString();
                }
            }

            return cipherText;

        }
        
        public static string Decrypt(string cipherText,int shift=3)
        {
            string plainText = "";
            for (int i = 0; i < cipherText.Length; i++)
            {
                int c = (int)cipherText[i];
                if (c == (int)'X')
                {
                    plainText += "A";

                }else if (c == (int)'Y')
                {
                    plainText += "B";
                }else if (c == (int)'Z')
                {
                    plainText += "C";
                }
                else
                {
                    char cc = (char) (c + shift);
                    plainText += cc.ToString();
                }
            }

            return plainText;

        }
    }
}