using System;

namespace lab01.Tasks
{
    public class Task4 
    {
        public Task4()
        {
            Console.WriteLine("Четвёртое задание");
            ExampleTuple();
            UnboxingTuple();
            CompareTuples();
        }
        
        public static void ExampleTuple()
        {
            (int, string, char, string, ulong) myTuple = (42, "Пример", 'A', "Еще пример", 21324432);
            int firstElement = myTuple.Item1;
            string secondElement = myTuple.Item2;
            char thirdElement = myTuple.Item3;
            string fourthElement = myTuple.Item4;
            ulong fifthElement = myTuple.Item5;

            Console.WriteLine($"Первый элемент: {firstElement}");
            Console.WriteLine($"Второй элемент: {secondElement}");
            Console.WriteLine($"Третий элемент: {thirdElement}");
            Console.WriteLine($"Четвертый элемент: {fourthElement}");
            Console.WriteLine($"Пятый элемент: {fifthElement}");
            Console.WriteLine($"Кортеж целиком: {myTuple}");
        }

        public static void UnboxingTuple()
        {
            var (firstElement, secondElement, _, _, _) = (42, "Пример", 'A', "Еще пример", 21324432);
            Console.WriteLine($"Первый элемент: {firstElement}");
            Console.WriteLine($"Второй элемент: {secondElement}");
        }

        public static void CompareTuples()
        {
            var tuple1 = (1, "Hello");
            var tuple2 = (1, "Hello");

            bool areEqual = tuple1 == tuple2;
            bool areNotEqual = tuple1 != tuple2;

            Console.WriteLine($"Равны?: {areEqual}"); // Выводит: "Are equal: True"
            Console.WriteLine($"Не равны?: {areNotEqual}"); // Выводит: "Are not equal: False"
        }
    }
}