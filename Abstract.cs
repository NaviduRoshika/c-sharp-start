using System;

namespace my_csharp
{
    abstract class Vehicle
    {

        public string Name { get; set; }

        public virtual void saySpic()
        {
            System.Console.WriteLine("I am Animal");
        }

        abstract public void sayModel();
    }

    class Car : Vehicle
    {

        public string Food { get; set; }
        public override void sayModel()
        {
            System.Console.WriteLine("I am a Car");
        }
    }

    class Bus : Vehicle
    {
        public void Fly()
        {
            System.Console.WriteLine("Flying");
        }
        public override void sayModel()
        {
            System.Console.WriteLine("I am a Bus");
        }
    }

}



namespace NewUniverse
{
    class PlanetX
    {
        public void sayHello()
        {
            System.Console.WriteLine("Hello there from planet X");
        }
    }

    namespace BlackHole
    {
        class NullVoid
        {
            public static void sayHello()
            {
                System.Console.WriteLine("Hello there from null void");
            }
        }
    }
}