using System;

namespace Inventory
{
    sealed partial class BasketballBall : Ball
    {
        public void Inflate()
        {
            IsInflated = true;
        }

        public bool IsFullyInflated()
        {
            return IsInflated;
        }

        public void Shoot()
        {
            if (IsInflated)
            {
                Console.WriteLine($"Баскетбольный мяч ({Name}) брошен!");
            }
            else
            {
                Console.WriteLine("Надуйте мяч перед броском.");
            }
        }
    }
}
