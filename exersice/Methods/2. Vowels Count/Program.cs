using System;
using System.Linq;

namespace _2._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine().ToLower();
            
            VowelsCount(line);


        }
        static void VowelsCount(string line)
        {
            char[] charArr = line.ToCharArray();
            int count = 0;
            foreach (char item in charArr)
            {
                if (item == 'a' || item == 'o' || item == 'u' || item == 'e' || item == 'i') count++;
            }
            Console.WriteLine(count);
        }
    }
}
