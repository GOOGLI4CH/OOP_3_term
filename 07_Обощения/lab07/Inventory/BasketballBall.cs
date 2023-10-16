using System;

namespace Inventory
{
    sealed class BasketballBall : Ball
    {
        public string Color { get; set; }
        public bool IsInflated { get; private set; }

        public BasketballBall(string name, double size, string color) : base(name, size)
        {
            Color = color;
            IsInflated = false;
        }

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

        public override string ToString()
        {
            return base.ToString() + $", Color: {Color}, IsInflated: {IsInflated}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            BasketballBall otherBall = (BasketballBall)obj;

            return (Name == otherBall.Name) &&
                   (Size == otherBall.Size) &&
                   (Color == otherBall.Color) &&
                   (IsInflated == otherBall.IsInflated);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17; // Простое начальное значение хеш-кода

                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Size.GetHashCode();
                hash = hash * 23 + Color.GetHashCode();
                hash = hash * 23 + IsInflated.GetHashCode();

                return hash;
            }
        }
    }
}
