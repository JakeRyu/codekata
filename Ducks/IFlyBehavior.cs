using System;

namespace Ducks
{
    public interface IFlyBehavior
    {
        void Fly();
    }

    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly with wings.");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Can't fly");
        }
    }
}