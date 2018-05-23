using System;

namespace Ducks2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallardDuck = new MallardDuck();
            mallardDuck.QuackBehavior = new QuackAsNormal();
            mallardDuck.FlyBehavior = new FlyWithWings();
            Console.WriteLine($"Mallard duck {new string('-', 50)}");
            mallardDuck.Swim();
            mallardDuck.PerformQuack();
            mallardDuck.PerformFly();

            var redheadDuck = new RedheadDuck();
            redheadDuck.QuackBehavior = new QuackAsNormal();
            redheadDuck.FlyBehavior = new FlyWithWings();
            Console.WriteLine($"Redhead duck {new string('-', 50)}");
            redheadDuck.Swim();
            redheadDuck.PerformQuack();
            redheadDuck.PerformFly();

            var rubberDuck = new RubberDuck();
            rubberDuck.QuackBehavior = new Sqeak();
            rubberDuck.FlyBehavior = new FlyNoWay();
            Console.WriteLine($"Rubber duck {new string('-', 50)}");
            rubberDuck.Swim();
            rubberDuck.PerformQuack();
            rubberDuck.PerformFly();

            var decoyDuck = new DecoyDuck();
            decoyDuck.QuackBehavior = new Mute();
            decoyDuck.FlyBehavior = new FlyNoWay();
            Console.WriteLine($"Decoy duck {new string('-', 50)}");
            decoyDuck.Swim();
            decoyDuck.PerformQuack();
            decoyDuck.PerformFly();
        }
    }
}
