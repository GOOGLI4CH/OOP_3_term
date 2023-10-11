using System;
using Inventory;

namespace lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = 500;
            GymContainer<Inventory.Inventory> container = new GymContainer<Inventory.Inventory>(budget);
            GymController<Inventory.Inventory> controller = new GymController<Inventory.Inventory>(container);

            container.Add(
                new BasketballBall("Баскетбольный мяч",
                7,
                "Оранжевый",
                Inventory.Inventory.ESports.Basketball,
                new Inventory.Inventory.Info("Новый баскетбольный мяч", 50))
                );
            container.Add(
                new Bench("Скамья",
                "Металл",
                150,
                30,
                Inventory.Inventory.ESports.Workout,
                new Inventory.Inventory.Info("Скамья для жима", 350))
                );
            container.Add(
                new BasketballBall("Баскетбольный мяч",
                7,
                "Красный",
                Inventory.Inventory.ESports.Basketball,
                new Inventory.Inventory.Info("Поношенный баскетбольный мяч", 30))
                );
            container.Add(
                new ParallelBars("Брусья",
                145.5,
                Inventory.Inventory.ESports.Workout,
                new Inventory.Inventory.Info("Брусья высотой 145.5 см.", 150))
                );

            Console.WriteLine("\n\nСписок снарядов до сортировки:");
            container.ShowInventory();
            controller.SortInventoryByPrice();
            Console.WriteLine("\n\nСписок снарядов после сортировки:");
            container.ShowInventory();
            Console.WriteLine("\n\nСнаряды из ценового диапазона 50-500:");

            foreach (var item in controller.FindItemsInPriceRange(50, 500))
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\nСписок снарядов после удаления:");
            container.Remove(
                new BasketballBall("Баскетбольный мяч",
                7,
                "Красный",
                Inventory.Inventory.ESports.Basketball,
                new Inventory.Inventory.Info("Поношенный баскетбольный мяч", 30))
                );
            container.ShowInventory();
        }
    }
}
