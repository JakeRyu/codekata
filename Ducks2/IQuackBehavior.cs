using System;

namespace Ducks2
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class QuackAsNormal : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class Sqeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Sqeak!");
        }
    }

    public class Mute : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< silence >>");
        }
    }
}