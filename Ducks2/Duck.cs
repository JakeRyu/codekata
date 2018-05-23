using System;

namespace Ducks2
{
    public class Duck
    {
        public IQuackBehavior QuackBehavior { get; set; }
        public IFlyBehavior FlyBehavior { get; set; }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("I can swim.");
        }

      

        public void Fly()
        {
            Console.WriteLine("I can fly.");
        }

    }

    public class MallardDuck : Duck{
    
    }


    public class RedheadDuck : Duck
    {
        
    }

    public class RubberDuck : Duck
    {
        
    }

    public class DecoyDuck : Duck
    {
       
    }
}