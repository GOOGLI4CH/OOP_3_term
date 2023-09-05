using System;

namespace lab01.Tasks
{
    public class Task6
    {
        public Task6()
        {
            CheckedExample();
            UncheckedExample();
        }
        
        static void CheckedExample()
        {
            try
            {
                checked
                {
                    int maxInt = int.MaxValue;
                    maxInt = maxInt + 1;
                    Console.WriteLine($"Значение с использованием checked: {maxInt}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Исключение при использовании checked: {ex.Message}");
            }
        }

        static void UncheckedExample()
        {
            unchecked
            {
                int maxInt = int.MaxValue;
                maxInt = maxInt + 1;
                Console.WriteLine($"Значение с использованием unchecked: {maxInt}");
            }
        }
    }
}