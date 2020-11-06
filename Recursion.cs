using System;
using System.IO;

namespace my_csharp
{
    public class Recursion
    {
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }else
            {
                return n * Factorial(n - 1);
            }
        }

        public static void DisplayFolders(string path,int indent)
        {
            foreach (var folder in Directory.GetDirectories(path))
            {
                Console.WriteLine($"{new string(' ',indent)} {Path.GetFileName(folder)}");
                DisplayFolders(folder,indent+2);
            }
        }

        public static void LoopThrouhArray<T>(params T[] items)
        {
            foreach (var VARIABLE in items)
            {
                Console.WriteLine(VARIABLE);
            }
        }

        public static void PerformMathOperations(params int[] numbers)
        {
            Console.WriteLine("ADD :- " + numbers);
        }
    }
}