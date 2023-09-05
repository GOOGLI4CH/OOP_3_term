using System;
using System.Text;

namespace lab01.Tasks
{
    public class Task2
    {
        public Task2()
        {
            Console.WriteLine("Второе задание");
            Literals();   
            StringsMethods();
            NullableString();
        }

        public static void Literals()
        {
            string str1 = "Hello, World!";
            string str2 = "Hello, World!";
            string str3 = "Goodbye, World!";

            if (str1 == str2)
            {
                Console.WriteLine("str1 и str2 равны.");
            }
            else
            {
                Console.WriteLine("str1 и str2 не равны.");
            }

            if (str1.Equals(str3))
            {
                Console.WriteLine("str1 и str3 равны.");
            }
            else
            {
                Console.WriteLine("str1 и str3 не равны.");
            }
        }

        public static void StringsMethods()
        {
            string str1 = "Hello";
            string str2 = "World";
            string str3 = "C#";

            string combinedString = string.Concat(str1, ", ", str2, "!");
            Console.WriteLine(combinedString);

            string copyOfString1 = string.Copy(str1);
            Console.WriteLine("Копия строки str1: " + copyOfString1);

            string substring = str2.Substring(0, 3);
            Console.WriteLine("Подстрока из str2: " + substring);

            string sentence = "Это пример разделения строки на слова";
            string[] words = sentence.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine("Слово: " + word);
            }

            string originalString = "Исходная строка";
            string insertedString = "вставленная ";
            int position = 8;
            string resultString = originalString.Insert(position, insertedString);
            Console.WriteLine("Результат вставки: " + resultString);

            string stringWithSubstring = "Удалим подстроку из этой строки";
            string substringToRemove = "подстроку ";
            string stringWithoutSubstring = stringWithSubstring.Replace(substringToRemove, "");
            Console.WriteLine("Результат удаления: " + stringWithoutSubstring);

            int number = 42;
            string interpolatedString = $"Значение переменной number: {number}";
            Console.WriteLine(interpolatedString);
        }

        public static void NullableString()
        {
            string emptyString = string.Empty;
            string nullString = null;

            if (string.IsNullOrEmpty(emptyString))
            {
                Console.WriteLine("emptyString является пустой строкой или null.");
            }
            else
            {
                Console.WriteLine("emptyString не является пустой строкой или null.");
            }

            if (string.IsNullOrEmpty(nullString))
            {
                Console.WriteLine("nullString является пустой строкой или null.");
            }
            else
            {
                Console.WriteLine("nullString не является пустой строкой или null.");
            }

            if (emptyString == null)
            {
                Console.WriteLine("emptyString равна null.");
            }
            else
            {
                Console.WriteLine("emptyString не равна null.");
            }

            if (nullString == null)
            {
                Console.WriteLine("nullString равна null.");
            }
            else
            {
                Console.WriteLine("nullString не равна null.");
            }

            string result1 = emptyString + "Это добавленный текст.";
            string result2 = nullString + "Это добавленный текст.";

            Console.WriteLine("Результат с пустой строкой: " + result1);
            Console.WriteLine("Результат с строкой null: " + result2);
        }

        public static void ChangeString()
        {
            StringBuilder stringBuilder = new StringBuilder("Пример строки на основе StringBuilder");

            stringBuilder.Remove(7, 5); // Удаляем "строку "
            Console.WriteLine("После удаления: " + stringBuilder);

            stringBuilder.Insert(0, "Это ");
            Console.WriteLine("После добавления в начало: " + stringBuilder);

            stringBuilder.Append(" с добавлениями.");
            Console.WriteLine("После добавления в конец: " + stringBuilder);
        }
        
    }
}