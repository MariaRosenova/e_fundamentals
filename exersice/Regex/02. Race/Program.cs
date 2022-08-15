using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {

            // more work here
            var patternForName = new Regex(@"(?<name>[A-Za-z]+)"); //pattern for finding the name
            var patternForDigit = @"?<digits>\d+"; //pattern for finding the digits
            var sumOfDigit = 0;

            // Dictionary for the participants
            var participants = new Dictionary<string, int>();

            //input of => List of the participants
            var names = Console.ReadLine().Split(", ").ToList(); // creating list 

            //reading the input after the names
            var input = Console.ReadLine();

            //Main logic.
            while (input != "end of race")
            {
                var matchedNames = patternForName.Matches(input); //finding the name(words)in array
                var matchedDigits = Regex.Match(input, patternForDigit);
                var currName = string.Join("", matchedNames); //joining the word
                var currDigit = string.Join("", matchedNames); //joining the digits
                sumOfDigit = 0;
                for (int i = 0; i < currDigit.Length; i++)
                {
                    // Convert current into integer value;
                    sumOfDigit = +int.Parse(currDigit[i].ToString());
                }
                // make a check if the current participant name exist in the list of names
                if (names.Contains(currName))
                {
                    // check if the participant name is not exist in the dictionary
                    if (!participants.ContainsKey(currName))
                    {
                        // we are adding the current name and sum of digits
                        participants.Add(currName, sumOfDigit);
                    }
                    else
                    {
                        //We are adding the sum of the current digits
                        participants[currName] += sumOfDigit;
                    }
                }


                input = Console.ReadLine();

            }

            //Finding the winners
            var winners = participants.OrderByDescending(x => x.Value)
            .Take(3);
            // Find the first place
            var firstPlace = winners.Take(1);
            var secondPlace = winners.Take(2);
            var thirdPlace = winners.Take(3);







            //var list = new List<string>(Console.ReadLine().Split(","));
            //string input = Console.ReadLine();
            //while (input!= "end of race")
            //{
            //    var regex = @"";
            //    Match matches = Regex.Match(input, regex, RegexOptions.IgnoreCase);
            //    foreach (string matchNames in list)
            //    {
            //        if ()
            //        {

            //        }

            //    }






            //input = Console.ReadLine();
        }
    }
}

