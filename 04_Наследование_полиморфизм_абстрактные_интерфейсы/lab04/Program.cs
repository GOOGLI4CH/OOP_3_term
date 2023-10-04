using System;
using Inventory;

namespace lab04
{
    internal class Printer
    {
        public void IAmPrinting(IActionable printableObject)
        {
            Console.WriteLine($"Тип объекта: {printableObject.GetType()}");
            Console.WriteLine(printableObject.ToString());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IActionable[] items = new IActionable[]
            {
                new BasketballBall("Баскетбольный мяч", 7, "Оранжевый"),
                new Bench("Скамья", "Дерево", 150, 30),
                new GymMat("Мат", "Розовый", 180, 30),
                new ParallelBars("Брусья", 145.5),
                new TennisBall("Теннисный мяч", 6.7, "Yonex")
            };
            
            Printer printer = new Printer();
            
            foreach (var item in items)
            {
                printer.IAmPrinting(item);
            }

            BasketballBall ball = new BasketballBall("Баскетбольный мяч", 7, "Оранжевый");

            // Пример использования методов
            Console.WriteLine(ball.Equals(printer));
            Console.WriteLine(ball.GetHashCode());
        }
    }
}
