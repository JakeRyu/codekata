using System;

namespace Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Duck mallard = new MallardDuck();
            Console.WriteLine($"Mallard duck {new string('.', 50)}");
            mallard.Swim();
            mallard.PerformFly();
            mallard.PerformQuack();
            mallard.Display();

            Duck crested = new CrestedDuck();
            Console.WriteLine($"Crested duck {new string('.', 50)}");
            crested.Swim();
            crested.PerformFly();
            crested.PerformQuack();
            crested.Display();

            Duck rubber = new RubberDuck();
            Console.WriteLine($"Rubber duck {new string('.', 50)}");
            rubber.Swim();
            rubber.PerformFly();
            rubber.PerformQuack();
            rubber.Display();

            Duck decoy = new DecoyDuck();
            Console.WriteLine($"Decoy duck {new string('.', 50)}");
            decoy.Swim();
            decoy.PerformFly();
            decoy.PerformQuack();
            decoy.Display();

            Console.WriteLine($"Decoy duck amended {new string('.', 50)}");
            decoy.Swim();
            decoy.FlyBehavior = new FlyWithWings();
            decoy.PerformFly();
            decoy.PerformQuack();
            decoy.Display();

        }
    }
}
