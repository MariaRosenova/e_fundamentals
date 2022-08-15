using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)"; // step one finding the regex
            string input = Console.ReadLine(); //reading the input
            var list = new List<string>(); //creating the list of items 
            double totalPrice = 0.0; //creating total price property

            while (input!="Purchase") //creating while loop to go through all inputs
            {
                Match matches = Regex.Match(input,regex,RegexOptions.IgnoreCase);
                if (matches.Success)
                {
                    var name = matches.Groups["name"].Value;
                    var price =double.Parse (matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    list.Add(name);
                    totalPrice += price * quantity;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {totalPrice:f2}");

        }
    }
}

