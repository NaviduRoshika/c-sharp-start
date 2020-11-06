using System;
using System.Collections.Generic;

namespace my_csharp
{
    public delegate void PlayerInfoDel();

    public delegate void PlayerInfoDelName(string name);

    public delegate void PlayerInfoDelGoals(string pname, int pgoals);

    public delegate void  DicValDel(Dictionary<int, string> dic);
        
    public class Delegates
    {
        
        public static void DisplayInfo()
        {
            Console.WriteLine("Player : Messy");
        }
        
        public static void DisplayInfo(string name)
        {
            Console.WriteLine("Player : " + name);
        }    
        public static void DisplayInfo(string name,int goals)
        {
            Console.WriteLine("Player : " + name + " Goals : " + goals);
        }    
    }
}