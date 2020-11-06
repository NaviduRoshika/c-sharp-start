using System;

namespace my_csharp
{
    class Normal
    {
        public static void First()
        {
            // StaticClass s = new StaticClass(); X
            StaticClass.GetName();
        }
    }

    static class StaticClass
    {
        //only static props and meth
        static public string name;
        static public void GetName()
        {
            System.Console.WriteLine(DateTime.Now.Year - DateTime.Now.AddYears(-2).Year);
        }
    }

}