using System;

namespace my_csharp
{
    public interface IBullDogs
    {
        void SayHi()
        {
            Console.WriteLine("dd");
        }

    }
    public interface IDogCommands : IBullDogs
    {
        void Stay()
        {
            Console.WriteLine("Stay");
        }
        void Sit();
        void Attack();

        string DogName
        {
            set;
            get;
        }
    }

    class BullDogs
    {
        private string BullName;

        public void sayHi()
        {
            Console.WriteLine("Hi from the bulldog");
        }
        
    }

    

    class Dogs :  BullDogs, IDogCommands
    {
        private string dogBreed;
        public void SayHi()
        {
            Console.WriteLine("Dog Say Hi");
        }

        public void Stay()
        {
            Console.WriteLine("Dog Stay");
        }

        public void Sit()
        {
            Console.WriteLine("Dog Sit");
        }

        public void Attack()
        {
            Console.WriteLine("Dog Attacked");
            sayHi();
        }

        public string DogName { get; set; }
    }
}