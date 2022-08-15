//using System;
//using System.Text.RegularExpressions;

//namespace _02._Message_Translator
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int times = int.Parse(Console.ReadLine());
//            string regex = @"!(?<forPrinting>[A-z][a-z]+)!:\[(?<charactersToGet>[A-z][a-z]+[A-z][a-z]+)\]"; // step one finding the regex
//            for (int i = 1; i <= times; i++)
//            {
//                string input = Console.ReadLine(); //reading the input

//                Match matches = Regex.Match(input, regex, RegexOptions.IgnoreCase);
//                if (matches.Success)
//                {
//                    var print = matches.Groups["forPrinting"].Value;
//                    var charactersForPrint = matches.Groups["charactersToGet"].Value;

//                    char[] charArr = charactersForPrint.ToCharArray();

//                    Console.Write(print +':' ) ;
//                    foreach (char character in charArr)
//                    {
//                        Console.Write();
//                    }
//                }
//            }

//        }
//    }
//}
using System;
using System.Text.RegularExpressions;

namespace MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            Regex patternRegexx = new Regex(@"\!([A-Z][a-z]{2,})\!\:\[([a-zA-z]{8,})\]");

            for (int i = 0; i < times; i++)
            {
                string inputs = Console.ReadLine();

                Match match = patternRegexx.Match(inputs);

                if (match.Success)
                {
                    string name = match.Groups[2].ToString();
                    string nums = string.Empty;
                    for (int j = 0; j < name.Length; j++)
                    {
                        int digit = name[j];
                        nums += digit + " ";

                    }
                    Console.WriteLine($"{match.Groups[1]}: {nums}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}