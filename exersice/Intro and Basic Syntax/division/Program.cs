using System;
using System.Runtime.CompilerServices;

namespace division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int free = 0;
            if (number % 10 == 0)
            {
                free = 10;
                Console.WriteLine($"The number is divisible by {free}");
            }
            else if (number % 7 == 0)
            {
                free = 7;
                Console.WriteLine($"The number is divisible by {free}");
            }
            else if (number % 6 == 0)
            {
                free = 6;
                Console.WriteLine($"The number is divisible by {free}");
            }
            else if (number % 3 == 0)
            {
                free = 3;
                Console.WriteLine($"The number is divisible by {free}");
            }
            else if (number % 2 == 0)
            {
                free = 2;
                Console.WriteLine($"The number is divisible by {free}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }    }
    }
}

