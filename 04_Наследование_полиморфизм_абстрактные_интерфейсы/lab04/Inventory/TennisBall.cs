using System;

namespace Inventory
{
    sealed class TennisBall : Ball
    {
        public string BallBrand { get; set; }

        public TennisBall(string name, double size, string ballBrand) : base(name, size)
        {
            BallBrand = ballBrand;
        }

        public override void PerformAction()
        {
            Console.WriteLine("Вы используете теннисный мяч");
        }

        public override string ToString()
        {
            return base.ToString() + $"Ball brand: {BallBrand}";
        }
    }
}
