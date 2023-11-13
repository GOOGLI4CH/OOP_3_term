using System.Collections.Generic;
using System.Linq;

namespace lab10.Tasks
{
    internal class Months
    {
        public static readonly string[] months =
        {
            "December", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November"
        };

        public Months() { }

        public static List<string> GetMonthByLength(int length) => months.Where(month => month.Length == length).ToList();

        public static List<string> GetSummerAndWinterMonths()
        {
            return months.Where(month => month == "December"
                                      || month == "January"
                                      || month == "February"
                                      || month == "June"
                                      || month == "July"
                                      || month == "August").ToList();
        }

        public static List<string> GetMonthInOrder() => months.OrderBy(month => month).ToList();

        public static int GetCountMonthByLetter(char letter) => months.Where(month => month.Contains(letter) && month.Length >= 4).Count();
    }
}
