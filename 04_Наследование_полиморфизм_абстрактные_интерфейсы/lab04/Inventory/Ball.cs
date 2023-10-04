using System;

namespace Inventory
{
    abstract class Ball : Inventory
    {
        public double Size { get; set; }

        public Ball(string name, double size) : base(name)
        { 
            Name = name;
            Size = size;
        }
        
        public override void ActionItem()
        {
            Console.WriteLine("Бросить мяч");
        }

        public override string ToString()
        {
            return base.ToString() + $", Size: {Size}";
        }
    }
}
