using System;
using Inventory;

namespace lab07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                CustomList<Inventory.Inventory> firstList = new CustomList<Inventory.Inventory>()
                {
                    new BasketballBall("Баскетбольный мяч", 7, "Оранжевый"),
                    new Bench("Скамья", "Металл", 150, 30),
                    new BasketballBall("Баскетбольный мяч", 7, "Красный"),
                    new ParallelBars("Брусья", 145.5),
                    new GymMat("Коврик для фитнесса", "Розовый", 2, 1)
                };
                CustomList<Inventory.Inventory> secondList = new CustomList<Inventory.Inventory>()
                {
                    new TennisBall("Теннисный мяч", 4, "SomeBrand")
                };
                CustomList<Inventory.Inventory> thirdList = new CustomList<Inventory.Inventory>()
                {
                    new TennisBall("Теннисный мяч", 3, "SomeBrand")
                };

                Console.WriteLine($"Первый элемент firstList:");
                firstList.Show(0);

                // Добавление элемента через метод Add и удаление через Remove
                secondList.Add(new BasketballBall("Баскетбольный мяч", 7, "Жёлтый"));
                Console.WriteLine("\n\nsecondList до удаления элемента:");
                foreach (var item in secondList)
                {
                    Console.WriteLine(item);
                }
             
                secondList.Remove(secondList.Count - 1);
                Console.WriteLine("\n\nsecondList после удаления элемента:");
                foreach (var item in secondList)
                {
                    Console.WriteLine(item);
                }

                CustomList<Inventory.Inventory> reversedList = !firstList;
                Console.WriteLine("\n\nРеверс списка:");
                foreach (var item in reversedList)
                {
                    Console.WriteLine(item);
                }

                CustomList<Inventory.Inventory> doubleList = firstList + thirdList;
                Console.WriteLine("\n\nСлияние двух списков:");
                foreach (var item in doubleList)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine($"\n\nПервый список равен второму: {firstList == secondList}");
                Console.WriteLine($"Первый список равен третьему: {firstList == thirdList}");

                try
                {
                    Console.WriteLine("\n\nСумма элементов двух списков:");
                    CustomList<Inventory.Inventory> listSumElements = thirdList < secondList;
                    foreach (var item in listSumElements)
                    {
                        Console.WriteLine(item);
                    }
                } 
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                firstList.WriteCollectionInFile("file.txt");
                Console.WriteLine("\n\nПрочитано из файла:");
                CustomList<Inventory.Inventory>.ReadCollectionFromFile("file.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }
        }
    }
}