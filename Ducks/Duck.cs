using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ducks
{
    // PROBLEMS
    // 1. Duck behaviors keeps changing across subclasses
    // 2. Using interfaces Flyable(), Quackable() can be overkill. 
    //    You have to track down and make a change across all subclasses when you want
    //      to modify behavior

    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; set; }
        public IQuackBehavior QuackBehavior { get; set; }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();   
        }

        public void Swim()
        {
            Console.WriteLine("Ducks are floating, even decoy!");
        }

        public virtual void Display()
        {
            Console.WriteLine("I look like a duck, but you don't know exactly.");
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new NormalQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I look like Mallard duck.");
        }
    }

    public class CrestedDuck : Duck
    {
        public CrestedDuck()
        {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new NormalQuack();
        }
        public override void Display()
        {
            Console.WriteLine("I look like Crested duck.");
        }
    }

    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Squeak();
        }
        public override void Display()
        {
            Console.WriteLine("I look like rubber duck.");
        }

    }

    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I look like decoy duck.");
        }
    }
}
