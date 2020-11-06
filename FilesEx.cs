using System;
using System.Data;
using System.IO;

namespace my_csharp
{
    public class FilesEx
    {
        enum Languages
        {
            English,Chinese,Arabic,German
        }

        public static void CreateFiles()
        {
            foreach (string i in Enum.GetNames(typeof(Languages)))
            {
                Directory.CreateDirectory(@"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/" + i.ToString());    
                string file = @"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/" +i.ToString() + "/log.txt";
                StreamWriter sw = new StreamWriter(file);
                DateTime date = DateTime.Now;
                sw.WriteLine("Hello...I know  : " + i.ToString());
                sw.WriteLine("Date : " + date.ToString("yyyy MMMM dd"));
                sw.WriteLine("Time : " + date.ToString("t"));
                sw.Close();
            }


        }

        public static void ReadeFiles()
        {
            foreach (string  i in Enum.GetNames(typeof(Languages)))
            {
                Directory.CreateDirectory(@"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/" + i.ToString());
                string file = @"/media/navidu/New Volume E/Tutorials/C#/CSharpFiles/" +i.ToString() + "/log.txt";
                StreamReader sr = new StreamReader(file);
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine("File ended");
                sr.Close();

            }
        }
        
    }
}