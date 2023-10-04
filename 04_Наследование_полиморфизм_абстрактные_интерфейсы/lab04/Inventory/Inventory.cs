using System;

namespace Inventory
{
    abstract class Inventory : IActionable
    {
        public string Name { get; set; }

        public Inventory(string name)
        {
            Name = name;
        }

        public abstract void ActionItem();

        public virtual void PerformAction()
        {
            Console.WriteLine($"Вы выполнили действие с инвентарем: {Name}");
        }

        public override string ToString()
        {
            return Name;
        }
    }
}