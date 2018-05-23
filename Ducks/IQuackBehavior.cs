using System;

namespace Ducks
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }

    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }

    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<<silence>>");
        }
    }
}