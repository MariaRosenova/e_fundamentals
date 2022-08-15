using System;
using System.Runtime.Serialization.Formatters;

namespace _8._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int cows = 1; cows <= number; cows++)
            {
                for (int rows = 1; rows <= cows; rows++)
                {
                    Console.Write($"{cows} ");
                }
                Console.WriteLine();
            }
        }
    }
}
