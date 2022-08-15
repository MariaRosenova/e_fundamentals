using System;
using System.Net.Http.Headers;

namespace _9._Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int free = 0;
            for (int i = 1; i <= n; i++)
            {
                free = 2 * i - 1;
                sum +=free;
                Console.WriteLine($"{free}");
            }
            Console.WriteLine($"Sum: {sum}");


        }

    }
}

