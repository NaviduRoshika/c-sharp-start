using System;
using System.IO;
namespace my_csharp
{
    public class CeaserCipherApp
    {
        public static void CeaserCiperEncryptApp()
        {
            DisplayMenu();
            bool exit = false;
            while (!exit)
            {
                // Console.Clear();
               
                ChangeColor('U');
                string choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "e":
                        EncryptMode();
                        break;
                    case "d":
                        DecryptMode();
                        break;
                    case "x":
                        Console.WriteLine("X");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }

        public static void DisplayMenu()
        {
           
            ChangeColor('A');
            Console.WriteLine("Encryption\t- E");
            Console.WriteLine("Decryption\t- D");
            Console.WriteLine("Exit\t\t- X");
            Console.WriteLine("Enter the Choice : ");
        }

        public static void ChangeColor(char type)
        {
            if (type == 'A')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
        }

        public static void EncryptMode()
        {
            string userName;
            string password;
            int shift;
            string message;
            string cipherText;
            Console.Clear();
            ChangeColor('A');
            Console.WriteLine("#######---------You Are Now In Encrypt Mode--------#######");
            
            Console.WriteLine("Enter Username\t:");
            ChangeColor('U');
            userName = Console.ReadLine();
            
            ChangeColor('A');
            Console.WriteLine("Enter Password\t: ");
            ChangeColor('U');
            password = Console.ReadLine();
            
            ChangeColor('A');
            Console.WriteLine("Enter Shift\t: ");
            ChangeColor('U');
            int.TryParse(Console.ReadLine(),out shift);
            if (shift == 0)
            {
                shift = 3;
            }
            ChangeColor('A');
            Console.WriteLine("Enter the message\t: ");
            ChangeColor('U');
            message = Console.ReadLine();
            
            cipherText =  Encrypt(message, shift);
            
            Directory.CreateDirectory(@"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/cipherApp");    
            string file = @"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/cipherApp/"+ userName+".txt";
            StreamWriter sw = new StreamWriter(file);
            sw.Write(userName + "-");
            sw.Write(password + "-");
            sw.Write(shift + "-");
            sw.WriteLine(cipherText);
            sw.Close();
            Console.Clear();
            Console.WriteLine("Your Encrypted message saved");
            DisplayMenu();
        }
        
        public static void DecryptMode()
        {
            string message;
            string cipherText;


            Console.Clear();
            ChangeColor('A');
            Console.WriteLine("#######---------You Are Now In Decrypt Mode--------#######");
            
            Console.WriteLine("Enter Username\t:");
            ChangeColor('U');
            var userName = Console.ReadLine();
            
            ChangeColor('A');
            Console.WriteLine("Enter Password\t: ");
            ChangeColor('U');
            var password = Console.ReadLine();
            
            ChangeColor('A');
            Console.WriteLine("Enter Shift\t: ");
            ChangeColor('U');
            int.TryParse(Console.ReadLine(),out var shift);
            
            // Directory.CreateDirectory(@"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/cipherApp");
            string file = @"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/cipherApp/" + userName + ".txt";
            
            try
            {
                StreamReader sr = new StreamReader(file);
                string userText = sr.ReadLine();
                sr.Close();
                string[] userTextArr = userText.Split("-");
                if (userTextArr[1] == password && int.Parse(userTextArr[2])==shift)
                {
                    cipherText = userTextArr[3];
                    message = Decrypt(cipherText,shift);
                    Console.Clear();
                    ChangeColor('A');
                    Console.WriteLine("Decrypted message\t:");
                    ChangeColor('U');
                    Console.WriteLine("- " +  message );
                    DisplayMenu();
                }
                else
                {
                    Console.Clear();
                    ChangeColor('U');
                    Console.WriteLine("Invalid credentials");
                    DisplayMenu();
                }

            }
            catch (Exception e)
            {
                Console.Clear();
                ChangeColor('U');
                Console.WriteLine("Invalid credentials");
                DisplayMenu();
                // throw;
            }
            
          
        }
        
        public static string Encrypt(string plainText,int shift)
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
                }else if (c == (int)' ')
                {
                    cipherText += "_";
                }
                else
                {
                    char cc = (char) (c - shift);
                    cipherText += cc.ToString();
                }
            }

            return cipherText;

        }
        
        public static string Decrypt(string cipherText,int shift)
        {
            string plainText = "";
            cipherText = cipherText.ToUpper();
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
                }else if (c == (int)'_')
                {
                    plainText += " ";
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