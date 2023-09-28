using System;

namespace lab02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Bus[] buses = new Bus[] 
            {
                new Bus(),
                new Bus("МАЗ"),
                new Bus("МАЗ", 15, 100000),
                new Bus("Иванов Иван Иванович", 1234, "35Б", "MERCEDES", 2, 100),
                new Bus("Петров Пётр Петрович", 1324, "35Б", "МАЗ", 5, 777),
                new Bus("Сидоров Сидр Сидорович", 1434, "35", "GAZ", 17, 666)
            };

            Console.WriteLine("Введите маршрут");
            string busWay = Console.ReadLine();

            foreach (var bus in buses)
            {
                if (bus.RouteNum == busWay)
                {
                    bus.ShowBus();
                }
            }

            Console.WriteLine("Введите срок эксплуатации");
            int year = Convert.ToInt32(Console.ReadLine());
            
            foreach (var bus in buses)
            {
                if (bus.YearExploitation >= year)
                {
                    bus.ShowBus();
                }
            }



            // Пример использования свойств
            //Bus myBus = new Bus();
            //myBus.BrandBus = "LOTOS";
            //Console.WriteLine(myBus.BrandBus);

            //foreach (var bus in buses)
            //{
            //    // Console.WriteLine(bus.GetHashCode());
            //    Console.WriteLine(bus.BrandBus);
            //    Console.WriteLine(bus.GetType());
            //    Console.WriteLine(bus.Equals(myBus));
            //}
        }
    }
}