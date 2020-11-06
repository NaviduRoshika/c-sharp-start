using System;
using System.Security.Cryptography;
using System.IO;
namespace my_csharp

{
    public class Encrypt
    {
        

        public static void MainX(string[] args)
        {
            DESCryptoServiceProvider key = new DESCryptoServiceProvider();
            Console.WriteLine("Enter your messages:");
            string plainText = Console.ReadLine();
            string cipherText = EncryptFunc(plainText,key);
            Console.WriteLine("\nCiper Text : " +cipherText);
            Console.WriteLine("Plain Text : " + DecryptFunc(cipherText,key));
            
        }

        public static string EncryptFunc(string palinText,SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms,key.CreateEncryptor(),CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.WriteLine(palinText);
            sw.Flush();
            cs.FlushFinalBlock(); 
            return (Convert.ToBase64String(ms.GetBuffer(),0,(int)ms.Length));
            
        }

        public static string DecryptFunc(string cipherText,SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText));
            CryptoStream cs = new CryptoStream(ms,key.CreateDecryptor(),CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }
    }
}