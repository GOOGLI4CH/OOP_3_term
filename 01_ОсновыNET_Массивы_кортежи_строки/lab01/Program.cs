using System;
using lab01.Tasks;

namespace lab01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            Task2 task2 = new Task2();
            Task3 task3 = new Task3();
            Task4 task4 = new Task4();
            
            // Task5
            static (int max, int min, int sum, char firstChar) CalculateStatistics(int[] numbers, string inputString)
            {
                if (numbers.Length == 0)
                {
                    throw new ArgumentException("Массив чисел не может быть пустым.", nameof(numbers));
                }

                int max = numbers[0];
                int min = numbers[0];
                int sum = 0;
                char firstChar = string.IsNullOrEmpty(inputString) ? '\0' : inputString[0];

                foreach (int number in numbers)
                {
                    if (number > max)
                        max = number;

                    if (number < min)
                        min = number;

                    sum += number;
                }

                return (max, min, sum, firstChar);
            }
            
            int[] numbers = { 4, 7, 1, 9, 2 };
            string inputString = "Hello, World!";
            
            var result = CalculateStatistics(numbers, inputString);

            Console.WriteLine($"Max: {result.max}");
            Console.WriteLine($"Min: {result.min}");
            Console.WriteLine($"Sum: {result.sum}");
            Console.WriteLine($"First Char: {result.firstChar}");

            Task6 task6 = new Task6();
        }
    }
}