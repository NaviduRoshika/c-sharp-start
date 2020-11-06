using System;

namespace my_csharp
{
    class VehicleP
    {
        public virtual void sayModel()
        {
            System.Console.WriteLine("I am Animal");
        }
    }

    class CarP : VehicleP
    {
        public override void sayModel()
        {
            System.Console.WriteLine("I am a Car");
        }
    }

    class BusP : VehicleP
    {

        public new void sayModel()  //igonre overide - run main sayModel()
        {
            System.Console.WriteLine("I am a Bus");
        }
    }

}