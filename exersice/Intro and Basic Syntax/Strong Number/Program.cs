using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= input; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
