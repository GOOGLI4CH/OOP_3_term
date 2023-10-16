using System;
using System.Text.RegularExpressions;

namespace lab08
{
    internal class StringHandler
    {
        public static string RemovePunctuation(string input)
        {
            return Regex.Replace(input, @"[^\w\s]", string.Empty);
        }

        public static string AddSymbol(string input, char symbol)
        {
            return input + symbol;
        }

        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }

        public static string RemoveExtraSpaces(string input)
        {
            return Regex.Replace(input, @"\s+", " ");
        }

        public static string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
