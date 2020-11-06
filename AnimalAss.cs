using System;

namespace my_csharp
{
    public class AnimalAss
    {
        protected string name;
        protected DateTime birthDate;
        protected string origin;
        

    }

    interface IDog
    {
        void Eat();
        void Drink();
        void Sit();
        void SayHi();
    }

    public enum Gender
    {
        Male,Female
    }

    public enum Training
    {
        Beginner,Intermediate,Expert
    }

    public enum Size
    {
        Small,Medium,Big
    }
    
    public class GermanShepard : AnimalAss,IDog
    {
        private Gender gender;
        private double weight;
        private bool securityGuard;
        private Training training;
        private Size size;
        
        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        
        public Training Training
        {
            get { return training; }
            set { training = value; }
        }
        
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        
        public bool SecurityGuard
        {
            get { return securityGuard; }
            set { securityGuard = value; }
        }
        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }

        public void Drink()
        {
            Console.WriteLine(name + "is Drinking");
        }

        public void Sit()
        {
            Console.WriteLine(name +  " is Sitting");
        }

        public void SayHi()
        {
            Console.WriteLine("Baw Baw Baw " + name);
        }
    }
} 