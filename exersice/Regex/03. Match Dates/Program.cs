using System;
using System.Text.RegularExpressions;
using System.Linq;


namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {  
            var regex = @"\b(?<day>\d{2})(?<separator>[-./])(?<month>[A-Z][a-z]+)\2(?<year>\d{4})";
            var dateStrings = Console.ReadLine();
            var dates = Regex.Matches(dateStrings, regex);

            GetRegexCode(dates);
        }

        private static void GetRegexCode(MatchCollection dates)
        {
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
