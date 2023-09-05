using System;

namespace lab01.Tasks
{
    public class Task3
    {
        public Task3()
        {
            Console.WriteLine("Третье задание");
            Matrix();
            ArrayOfStrings();
            ArrayOfNumbers();
            SaveStringArray();
        }
        
        public static void Matrix()
        {
            int[,] matrix = {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
            };

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            Console.WriteLine("Матрица:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void ArrayOfStrings()
        {
            string[] stringArray = { "apple", "banana", "cherry", "date", "grape" };

            Console.WriteLine("Содержимое массива строк:");
            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine($"[{i}] {stringArray[i]}");
            }
            
            Console.WriteLine("Длина массива: " + stringArray.Length);

            Console.Write("Введите индекс элемента для изменения: ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < stringArray.Length)
            {
                Console.Write("Введите новое значение: ");
                string newValue = Console.ReadLine();

                stringArray[index] = newValue;

                Console.WriteLine("Обновленное содержимое массива:");
                for (int i = 0; i < stringArray.Length; i++)
                {
                    Console.WriteLine($"[{i}] {stringArray[i]}");
                }
            }
            else
            {
                Console.WriteLine("Недопустимый индекс.");
            }
        }

        public static void ArrayOfNumbers()
        {
            int numRows = 3;
            int[][] jaggedArray = new int[numRows][];

            for (int i = 0; i < numRows; i++)
            {
                Console.Write($"Введите количество элементов в строке {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int numColumns) && numColumns > 0)
                {
                    jaggedArray[i] = new int[numColumns];

                    for (int j = 0; j < numColumns; j++)
                    {
                        Console.Write($"Введите значение для элемента [{i}, {j}]: ");
                        if (int.TryParse(Console.ReadLine(), out int value))
                        {
                            jaggedArray[i][j] = value;
                        }
                        else
                        {
                            Console.WriteLine("Неверный формат числа. Попробуйте снова.");
                            j--;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Неверное количество столбцов. Попробуйте снова.");
                    i--;
                }
            }

            Console.WriteLine("Введенный ступенчатый массив:");

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void SaveStringArray()
        {
            var intArray = new[] { 1, 2, 3, 4, 5 };
            
            var str = "Пример строки";

            Console.WriteLine("Массив целых чисел:");
            foreach (var item in intArray)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Строка: " + str);
        }
    }
}