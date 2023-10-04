using System;

namespace Inventory
{
    internal class ParallelBars : Inventory
    {
        public double Height { get; set; }

        public ParallelBars(string name, double height) : base(name)
        {
            Height = height;
        }

        public override void ActionItem()
        {
            Console.WriteLine("Отжиматься на брусьях");
        }

        public override string ToString()
        {
            return base.ToString() + $"Height: {Height}";
        }
    }
}

