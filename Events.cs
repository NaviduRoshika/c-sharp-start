using System;
namespace my_csharp
{
    public delegate void myDelegate(string name);
    
    public class Events
    {
        public event myDelegate myEvent;

        public static void MainX(string[] args)
        {
            Events ev = new Events();
           
            ev.myEvent("Alex");
        }
        public Events()
        {
            myEvent += DisplayInfoEngilsh;
            myEvent += new myDelegate(DisplayInfoJapan);
            myEvent += DisplayInfoChineese;
        }
        
        public static void DisplayInfoEngilsh(string name)
        {
            Console.WriteLine("Lang : English " + name);
        }

        public static void DisplayInfoChineese(string name)
        {
            Console.WriteLine("Lang : Chineese " + name);
        }

        public static void DisplayInfoJapan(string name)
        {
            Console.WriteLine("Lang : Japan " + name);
        }
    }
}