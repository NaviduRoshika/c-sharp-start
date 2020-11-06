using System;

namespace my_csharp
{
    public class Indexers
    {
        private string[] stringArr = new string[100];

        public string this[int index]
        {
            get { return stringArr[index]; }
            set { stringArr[index] = value; }
        }

        ~Indexers()
        {
            // Console.WriteLine("INdexers Destructed");
        }
    }
}