using lab10.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;

namespace lab10
{
    internal class Program
    {
        private static void PrintList(List<string> list)
        {
            foreach (string month in list)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("\n");
        }

        private static void Task1()
        {
            Console.WriteLine("Первое задание\n");

            List<string> monthsByLength = Months.GetMonthByLength(5);
            Console.WriteLine("Длина названия месяца равна 5 символам:");
            PrintList(monthsByLength);

            List<string> summerAndWinterMonths = Months.GetSummerAndWinterMonths();
            Console.WriteLine("Летние и зимние месяцы:");
            PrintList(summerAndWinterMonths);

            List<string> monthsInOrder = Months.GetMonthInOrder();
            Console.WriteLine("Месяцы в алфавитном порядке:");
            PrintList(monthsInOrder);

            int count = Months.GetCountMonthByLetter('u');
            Console.WriteLine($"Количество месяцев содержащих букву 'u' длинной более 4: {count}\n");
        }

        private static void PrintBusList(List<Bus> list)
        {
            foreach (Bus bus in list)
            {
                Console.WriteLine(bus);
            }
            Console.WriteLine("\n");
        }

        private static void Task2()
        {
            Console.WriteLine("Второе задание\n");

            BusList busList = new BusList();

            busList.AddBus(new Bus("МАЗ"));
            busList.AddBus(new Bus("МАЗ", 15, 100000));
            busList.AddBus(new Bus("Сидоров Сидр Сидорович", 1434, "35", "GAZ", 17, 666));
            busList.AddBus(new Bus("Иванов Иван Иванович", 1234, "35Б", "MERCEDES", 2, 100));
            busList.AddBus(new Bus("Петров Пётр Петрович", 1324, "35Б", "МАЗ", 5, 777));

            List<Bus> busesByRouteNum = busList.GetBusesByRouteNum("35Б");
            Console.WriteLine("Автобусы с номером '35Б':");
            PrintBusList(busesByRouteNum);

            List<Bus> BusesUsedMorePeriod = busList.GetBusesUsedMorePeriod(10);
            Console.WriteLine("Автобусы, которые эксплуатируются больше заданного срока:");
            PrintBusList(BusesUsedMorePeriod);

            Bus busWithMinMileage = busList.GetBusByMinMileage();
            Console.WriteLine($"Автобус с минимальным пробегом: \n{busWithMinMileage}");

            List<Bus> latestBusesWithMaxMileage = busList.GetLatestBusesWithMaxMileage();
            Console.WriteLine("Последние два автобуса максимальные по пробегу:");
            PrintBusList(latestBusesWithMaxMileage);

            List<Bus> busesOrderedByNum = busList.GetBusesOrderedByNum();
            Console.WriteLine("Автобусы, упорядоченные по номеру:");
            PrintBusList(busesOrderedByNum);
        }

        static void Task3()
        {
            Console.WriteLine("Третье задание\n");

            List<Bus> buses = new List<Bus>
            {
                new Bus("Иванов Иван Иванович", 101, "32", "ПАЗ", 2015, 12345),
                new Bus("Петров Петр Петрович", 102, "15", "ЛиАЗ", 2010, 45678),
                new Bus("Сидоров Сидр Сидорович", 103, "130", "МАЗ", 2012, 23001),
                new Bus("НефАЗ", 2018)
            };

            var query = buses
                    .Where(b => b.Mileage > 100000)
                    .Select(b => new
                    {
                        b.BrandBus,
                        b.Mileage
                    })
                    .OrderByDescending(b => b.Mileage)
                    .GroupBy(b => b.BrandBus)
                    .SelectMany(g => g.Take(2))
                    .Select(b => new
                    {
                        Brand = b.BrandBus,
                        TotalMileage = b.Mileage
                    })
                    .Any(b => b.TotalMileage > 200000);

            Console.WriteLine(query);
        }

        public class BusShort
        {
            public int BusId { get; set; }
            public string Brand { get; set; }
        }

        public class Driver
        {
            public int DriverId { get; set; }
            public string Name { get; set; }
            public int BusId { get; set; }
        }

        static void Task4()
        {
            Console.WriteLine("Четвёртое задание\n");

            List<BusShort> buses = new List<BusShort>
            {
              new BusShort {BusId = 1, Brand = "ПАЗ"},
              new BusShort {BusId = 2, Brand = "ЛиАЗ"},
              new BusShort {BusId = 3, Brand = "МАЗ"}
            };

            List<Driver> drivers = new List<Driver>
            {
              new Driver {DriverId = 1, Name = "Иванов И.И.", BusId = 1},
              new Driver {DriverId = 2, Name = "Петров П.П.", BusId = 2},
              new Driver {DriverId = 3, Name = "Сидоров С.С.", BusId = 3}
            };

            var query = buses.Join(
              drivers,
              bus => bus.BusId,
              driver => driver.BusId,
              (bus, driver) => new
              {
                  BusBrand = bus.Brand,
                  DriverName = driver.Name
              }
            );

            foreach (var item in query)
            {
                Console.WriteLine($"Автобус {item.BusBrand} - Водитель {item.DriverName}");
            }
        }

        static void Main(string[] args)
        {
            //Task1();
            Task2();
            Task3();
            Task4();
        }
    }
}
