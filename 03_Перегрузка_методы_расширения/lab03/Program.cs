using System;

namespace lab03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            CustomList<int> firstList = new CustomList<int>() {1, 2, 3, 4, 5};
            CustomList<int> secondList = new CustomList<int>() { 6, 7, 8, 9, 10 };
            CustomList<int> thirdList = new CustomList<int>() { 1, 2, 3 };

            CustomList<int> reversedList = !thirdList;
            Console.WriteLine("Реверс списка:");
            foreach (int item in reversedList)
            {
                Console.WriteLine(item);
            }

            CustomList<int> doubleList = firstList + thirdList;
            Console.WriteLine("Слияние двух списков:");
            foreach (int item in doubleList)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine($"Первый список равен второму: {firstList == secondList}");
            Console.WriteLine($"Первый список равен третьему: {firstList == thirdList}");

            CustomList<int> listSumElements = firstList < secondList;
            Console.WriteLine("Сумма элементов двух списков:");
            foreach (int item in listSumElements)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine($"Сумма элементов первого списка: {firstList.SumElements(firstList)}");

            string myString = "Hello, world!";

            Console.WriteLine($"Первоначальная строка: {myString}");
            Console.WriteLine($"Усечённая строка: {myString.Truncate(5)}");
        }
    }
}