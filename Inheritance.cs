using System;

namespace my_csharp
{
    class Animal
    {

        public string Name { get; set; }

        public virtual void saySpic()
        {
            System.Console.WriteLine("I am Animal");
        }
    }

    #region Dog - This is for DOGS
    class Dog : Animal
    {

        public string Food { get; set; }
        public void Bark()
        {
            System.Console.WriteLine("Baw2" + Food);
        }
        public override void saySpic()
        {
            System.Console.WriteLine("I am Dog");
        }
    }
    #endregion

    class Bird : Animal
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying");
        }
        public override void saySpic()
        {
            System.Console.WriteLine("I am Bird");
        }
    }

}