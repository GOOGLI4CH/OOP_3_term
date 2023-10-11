namespace Inventory
{
    sealed partial class BasketballBall : Ball
    {
        public string Color { get; set; }
        public bool IsInflated { get; private set; }

        public BasketballBall(string name, double size, string color, ESports type, Info info) : base(name, size, type, info)
        {
            Color = color;
            IsInflated = false;
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
                int hash = 17;

                hash = hash * 23 + Name.GetHashCode();
                hash = hash * 23 + Size.GetHashCode();
                hash = hash * 23 + Color.GetHashCode();
                hash = hash * 23 + IsInflated.GetHashCode();

                return hash;
            }
        }
    }
}
