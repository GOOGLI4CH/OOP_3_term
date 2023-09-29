using System;

public static class StringExtensions
{
    public static string Truncate(this string input, int maxLength)
    {
        if (input == null)
        {
            throw new ArgumentNullException(nameof(input));
        }

        if (input.Length <= maxLength)
        {
            return input;
        }

        return input.Substring(0, maxLength);
    }
}