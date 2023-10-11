using System;

namespace Inventory
{
    abstract class Inventory
    {
        public string Name { get; set; }
        public ESports TypeSport { get; set; }
        public Info EquipmentInfo { get; set; }

        public enum ESports
        {
            Basketball, Tennis, Fitness, Workout 
        }

        public struct Info
        {
            public string Description { get; set; }
            public double Price { get; set; }

            public Info(string description, double price)
            {
                Description = description;
                Price = price;
            }
        }

        public Inventory(string name, ESports typeSport, Info info)
        {
            Name = name;
            TypeSport = typeSport;
            EquipmentInfo = info;
        }

        public abstract void ActionItem();

        public virtual void PerformAction()
        {
            Console.WriteLine($"Вы выполнили действие с инвентарем: {Name}");
        }

        public override string ToString()
        {
            return $"{Name}, Description: {EquipmentInfo.Description}, Price: {EquipmentInfo.Price}";
        }
    }
}