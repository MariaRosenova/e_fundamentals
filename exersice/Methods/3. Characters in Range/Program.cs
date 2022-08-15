using System;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            CharsInARange(firstChar, secondChar);
        }
        static void CharsInARange(char firstChar, char secondChar)
        {
            int startChar = Math.Min(firstChar, secondChar);
            int endChar = Math.Max(firstChar,secondChar);
            for (int i = firstChar+1; i < secondChar; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();

        }
    }
}
