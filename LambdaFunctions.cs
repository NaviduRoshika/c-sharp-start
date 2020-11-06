using System;

namespace my_csharp
{
    public class LambdaFunctions
    {
        public static void SayHi(string name) => Console.WriteLine("Hi Bokka.. " + name);

        //Expression bodied methods
        public static int AddNumbers(int x, int y) => x + y;
        
    }
    
    public class AnimalsLambda
    {
        public AnimalsLambda() => Console.WriteLine("A new Animal Created...");

        private string name;

        public string Name
        {
            get => name;
            set => name = value;
        }
    }
}