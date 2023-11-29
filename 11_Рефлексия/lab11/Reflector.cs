using System.Linq;
using System.Reflection;
using System;
using System.IO;
using System.Collections.Generic;

namespace lab11
{
    public static class Reflector
    {
        public static string GetAssemblyName(Type type)
        {
            var assembly = type.Assembly;

            return assembly.GetName().Name;
        }

        public static string HasPublicConstructors(Type type)
        {
            var constructors = type.GetConstructors();

            return $"{constructors.Any(c => c.IsPublic)}";
        }

        public static IEnumerable<string> GetMethodsNames(Type type)
        {
            var methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            return methods.Select(m => m.Name);
        }

        public static IEnumerable<string> GetFieldsAndPropertiesNames(Type type)
        {
            var fields = GetMembersNames(type.GetFields(BindingFlags.Public | BindingFlags.Instance));
            var properties = GetMembersNames(type.GetProperties(BindingFlags.Public | BindingFlags.Instance));
            return fields.Concat(properties);
        }

        public static IEnumerable<string> GetInterfacesNames(Type type)
        {
            return type.GetInterfaces().Select(i => i.FullName);
        }

        private static IEnumerable<string> GetMembersNames(MemberInfo[] members)
        {
            return members.Select(m => m.Name);
        }

        public static string GetMethodsByParamType(Type type, Type paramType)
        {
            var methods = type.GetMethods()
              .Where(m => m.GetParameters()
                .Any(p => p.ParameterType == paramType))
              .Select(m => m.Name);

            return String.Join(Environment.NewLine, methods);
        }

        public static void WriteResultsTofile(string typeName, string fileName)
        {
            var type = Type.GetType(typeName);

            var results =
              $"Имя сборки: {GetAssemblyName(type)}{Environment.NewLine}" +
              $"Наличие публичных конструкторов: {HasPublicConstructors(type)}{Environment.NewLine}" +
              $"Названия методов: {String.Join(Environment.NewLine, GetMethodsNames(type))}{Environment.NewLine}" +
              $"Названия методов с определёнными параметрами: {Reflector.GetMethodsByParamType(type, typeof(string))}" +
              $"Названия полей и свойств: {String.Join(Environment.NewLine, GetFieldsAndPropertiesNames(type))}{Environment.NewLine}" +
              $"Названия интерфейсов: {String.Join(Environment.NewLine, GetInterfacesNames(type))}{Environment.NewLine}";

            using (StreamWriter writer = File.CreateText(fileName))
            {
                writer.Write(results);
            }
        }
    }
}