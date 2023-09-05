using System;

namespace lab01.Tasks
{
    public class Task1
    {
        public Task1()
        {
            Console.WriteLine("Первое задание");
            Types();
            LearnConvert();
            Boxing();
            ImplicitType();
            NullableType();
        }
        
        public static void Types()
        { 
            // Целочисленные типы
            sbyte sbyteVar = 10;
            byte byteVar = 20;
            short shortVar = 30;
            ushort ushortVar = 40;
            int intVar = 50;
            uint uintVar = 60;
            long longVar = 70;
            Console.WriteLine("Введите число: ");
            ulong ulongVar = Convert.ToUInt64(Console.ReadLine());

            // Вещественные типы
            float floatVar = 3.14f;
            double doubleVar = 3.14159;
            decimal decimalVar = 3.1415926535m;

            // Символьный тип
            char charVar = 'A';

            // Логический тип
            bool boolVar = true;
            
            Console.WriteLine(sbyteVar);
            Console.WriteLine(byteVar);
            Console.WriteLine(shortVar);
            Console.WriteLine(ushortVar);
            Console.WriteLine(intVar);
            Console.WriteLine(uintVar);
            Console.WriteLine(longVar);
            Console.WriteLine(ulongVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(doubleVar);
            Console.WriteLine(decimalVar);
            Console.WriteLine(charVar);
            Console.WriteLine(boolVar);
        }

        public static void LearnConvert()
        {
            Console.WriteLine("Неявные преобразования");
            
            int iVar = 5;
            double dVar = iVar;
            float fVar = iVar;
            long lVar = iVar;
            short sVar = 5;
            iVar = sVar;
            decimal deVar = iVar;
            
            Console.WriteLine(iVar.GetType());
            Console.WriteLine(dVar.GetType());
            Console.WriteLine(fVar.GetType());
            Console.WriteLine(lVar.GetType());
            Console.WriteLine(iVar.GetType());
            Console.WriteLine(deVar.GetType());
            
            Console.WriteLine("Явные преобразования");
            
            string str = "555";
            bool bVar = true;
            iVar = Convert.ToInt32(str);
            str = "55,5";
            fVar = Convert.ToSingle(str);
            iVar = (int)fVar;
            str = "true";
            bVar = Convert.ToBoolean(str);
            deVar = Convert.ToDecimal(deVar);
            str = "2023-09-04";
            DateTime dateVar = Convert.ToDateTime(str);
            
            Console.WriteLine(str.GetType());
            Console.WriteLine(iVar.GetType());
            Console.WriteLine(fVar.GetType());
            Console.WriteLine(iVar.GetType());
            Console.WriteLine(bVar.GetType());
            Console.WriteLine(deVar.GetType());
            Console.WriteLine(dateVar.GetType());
        }

        public static void Boxing()
        {
            int iVar = 5;
            object myObject = iVar;
            int unboxedVar = (int)myObject;

            Console.WriteLine($"Тип значения: {iVar.GetType()}");
            Console.WriteLine($"Тип запакованного значения: {myObject.GetType()}");
            Console.WriteLine($"Тип распакованного значения: {unboxedVar.GetType()}");
        }

        public static void ImplicitType ()
        {
            var myVarInt = 42;
            var myVarString = "Привет, мир!";
            var myVarArray = new[] { 1, 2, 3, 4, 5 };
            var myVarObject = new { Name = "John", Age = 30 };

            Console.WriteLine("Тип myVarInt: " + myVarInt.GetType());
            Console.WriteLine("Тип myVarString: " + myVarString.GetType());
            Console.WriteLine("Тип myVarArray: " + myVarArray.GetType());
            Console.WriteLine("Тип myVarObject: " + myVarObject.GetType());
        }

        public static void NullableType()
        {
            int? nullVar = null;

            if (nullVar.HasValue)
            {
                Console.WriteLine($"Переменная имеет значение {nullVar}");
            }
            else
            {
                Console.WriteLine($"Переменная не имеет значения {nullVar}");
            }

            nullVar = 5;
            
            if (nullVar.HasValue)
            {
                Console.WriteLine($"Переменная имеет значение {nullVar}");
            }
            else
            {
                Console.WriteLine($"Переменная не имеет значения {nullVar}");
            }
        }
    }
}