using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // var regex = @"\+(\d{3})(?<separator>[- ])\d{1}\2\d{3}\2\d{4}\b";
            // var input = Console.ReadLine();
            //var matches = Regex.Match(input, regex);

            var regex = @"\+(\d{3})(?<separator>[- ])\d{1}\2\d{3}\2\d{4}\b";
            var phones = Console.ReadLine();
            var phoneMatches = Regex.Matches(phones, regex);
            var matchedPhones = phoneMatches
                .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));

        }
    }
}
