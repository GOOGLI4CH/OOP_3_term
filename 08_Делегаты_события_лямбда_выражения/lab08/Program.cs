using System;

namespace lab08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("User1", 1);
            User user2 = new User("User2", 2);
            User user3 = new User("User3", 3);
            User user4 = new User("User4", 4);
            User user5 = new User("User5", 5);

            user1.Upgrade += message => Console.WriteLine($"Событие Upgrade: {message}");
            user1.Work += typeWork => Console.WriteLine($"Событие Work: {typeWork}");

            user2.Upgrade += message => Console.WriteLine($"Событие Upgrade: {message}");
            user2.Work += typeWork => Console.WriteLine($"Событие Work: {typeWork}");

            user3.Upgrade += message => Console.WriteLine($"Событие Upgrade: {message}");
            user3.Work += typeWork => Console.WriteLine($"Событие Work: {typeWork}");

            user4.Upgrade += message => Console.WriteLine($"Событие Upgrade: {message}");
            user4.Work += typeWork => Console.WriteLine($"Событие Work: {typeWork}");

            user5.Upgrade += message => Console.WriteLine($"Событие Upgrade: {message}");
            user5.Work += typeWork => Console.WriteLine($"Событие Work: {typeWork}");

            user1.DoUpgrade(2);
            user1.DoWork("Task 1");

            Console.WriteLine();

            user2.DoUpgrade(3);
            user2.DoWork("Task 2");

            Console.WriteLine();

            user3.DoUpgrade(4);
            user3.DoWork("Task 3");

            Console.WriteLine();

            user4.DoUpgrade(5);
            user4.DoWork("Task 4");

            Console.WriteLine();

            user5.DoUpgrade(6);
            user5.DoWork("Task 5");

            Console.WriteLine();

            Console.WriteLine("Введите строку для обработки");
            string input = Console.ReadLine();

            Action<string> processString = inputString =>
            {
                Console.WriteLine("Input: " + inputString);

                inputString = StringHandler.RemovePunctuation(inputString);
                Console.WriteLine("After removing punctuation: " + inputString);

                inputString = StringHandler.AddSymbol(inputString, '*');
                Console.WriteLine("After adding a symbol: " + inputString);

                inputString = StringHandler.ToUpperCase(inputString);
                Console.WriteLine("After converting to uppercase: " + inputString);

                inputString = StringHandler.RemoveExtraSpaces(inputString);
                Console.WriteLine("After removing extra spaces: " + inputString);

                inputString = StringHandler.Reverse(inputString);
                Console.WriteLine("After reversing: " + inputString);

                Console.WriteLine();
            };

            processString(input);

            Predicate<string> isEmptyString = inputString =>
            {
                return inputString.Length == 0;
            };

            Console.WriteLine($"Проверка на пустоту: {isEmptyString(input)}");
            Console.WriteLine();

            Func<string, string, string> concatString = (inputString, stringToConnect) =>
            {
                return inputString + stringToConnect;
            };

            Console.WriteLine($"Конкатенация строк: {concatString(input, "connect")}");
            Console.WriteLine();
        }
    }
}
