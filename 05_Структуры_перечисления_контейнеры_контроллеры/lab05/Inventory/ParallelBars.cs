using System;

namespace Inventory
{
    internal class ParallelBars : Inventory
    {
        public double Height { get; set; }

        public ParallelBars(string name, double height, ESports type, Info info) : base(name, type, info)
        {
            Height = height;
        }

        public override void ActionItem()
        {
            Console.WriteLine("Отжиматься на брусьях");
        }

        public override string ToString()
        {
            return base.ToString() + $", Height: {Height}";
        }
    }
}

