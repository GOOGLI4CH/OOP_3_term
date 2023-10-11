using System;

namespace Inventory
{
    internal class Bench : Inventory
    {
        public string Material { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public Bench(string name, string material, int length, int width, ESports type, Info info) : base(name, type, info)
        {
            Material = material;
            Length = length;
            Width = width;
        }

        public override void ActionItem()
        {
            Console.WriteLine("Лечь на скамью для ");
        }

        public override string ToString()
        {
            return base.ToString() + $", Material: {Material}, Lenght: {Length}, Width: {Width}";
        }
       
    }
}
