using System;

namespace lab11
{
    public class Program
    {
        static void AnalyzeClass(string className)
        {
            var type = Type.GetType(className);

            Console.WriteLine($"Класс: {className}");
            Console.WriteLine($"Имя сборки: {Reflector.GetAssemblyName(type)}");
            Console.WriteLine($"Наличие публичных конструкторов: {Reflector.HasPublicConstructors(type)}");
            Console.WriteLine($"Названия методов: {String.Join(Environment.NewLine, Reflector.GetMethodsNames(type))}");
            Console.WriteLine($"Названия методов с определёнными параметрами: {Reflector.GetMethodsByParamType(type, typeof(object))}");
            Console.WriteLine($"Названия полей и свойств: {String.Join(Environment.NewLine, Reflector.GetFieldsAndPropertiesNames(type))}");
            Console.WriteLine($"Названия интерфейсов: {String.Join(Environment.NewLine, Reflector.GetInterfacesNames(type))}");

            Reflector.WriteResultsTofile(className, "object.txt");
        }

        static void Main(string[] args)
        {
            AnalyzeClass("System.Object");
        }
    }
}
