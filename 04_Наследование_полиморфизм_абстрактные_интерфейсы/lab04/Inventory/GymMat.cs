using System;

namespace Inventory
{
    internal class GymMat : Inventory
    {
        public string Color { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public GymMat(string name, string color, int length, int width) : base(name)
        {
            Color = color;
            Length = length;
            Width = width;
        }

        public override void ActionItem()
        {
            Console.WriteLine("Лечь на мат");
        }

        public override string ToString()
        {
            return base.ToString() + $"Color: {Color}, Length: {Length}, Width: {Width}";
        }
    }
}
