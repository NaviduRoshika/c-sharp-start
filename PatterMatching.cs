using System;

namespace my_csharp
{
    public class PatterMatching
    {
        public static void MainX(string[] args)
        {
            Cat cat = new Cat();
            Monkey mon = new Monkey();
            Bat bat = new Bat();
            Doge dog = new Doge();
            AnimalSoundIS(cat);
            AnimalSoundIS(mon);
            AnimalSoundIS(bat);
            AnimalSoundIS(dog);
            Console.WriteLine();
            AnimalSoundSwitch(cat);;
            AnimalSoundSwitch(mon);
            AnimalSoundSwitch(bat);
            AnimalSoundSwitch(dog);
            Console.WriteLine();
            AnimalSoindSwitchAndWHen(dog);
            
        }
        //Using IS
        public static void AnimalSoundIS(object animal)
        {
            if (animal is Cat)
            {
                Console.WriteLine("Meeeeoooww");
            }else if (animal is Monkey)
            {
                Console.WriteLine("Buh buhu");
            }else if (animal is Bat)
            {
                Console.WriteLine("Teeeeeeeeeeeee");
            }else if (animal is Doge)
            {
                Console.WriteLine("Baw Baw");
            }
            else
            {
                Console.WriteLine("Unknown Animal");
            }
        }
        //USING SWITCH
        public static void AnimalSoundSwitch(object animal)
        {
            switch (animal)
            {
                case Cat c:
                    Console.WriteLine("Meeeeoooww");
                    break;
                case Monkey m:
                    Console.WriteLine("Buh buhu");
                    break;
                case Bat b:
                    Console.WriteLine("Teeeeeeeeeeeee");
                    break;
                case Doge d:
                    Console.WriteLine("Baw Baw");
                    break;
                default:
                    Console.WriteLine("Unknown Animal");
                    break;
                
            }
            
        }
        //USING SWITCH AND WHEN
        public static void AnimalSoindSwitchAndWHen(object animal)
        {
            switch (animal)
            {
                case Cat c when c.Name==null: Console.WriteLine("Name is Null");
                    break;
            }
        }
        
    }

    class Cat
    {
        public string Name { get; set; }
    }
    class Monkey
    {
        public string Name { get; set; }
    }
    class Bat
    {
        public string Name { get; set; }
    }
    class Doge
    {
        public string Name { get; set; }
    }
}