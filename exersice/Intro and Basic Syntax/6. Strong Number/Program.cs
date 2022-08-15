using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temNumber = number;
            int factorialSum = 0;
            while (temNumber>0)
            {
                int currNumber = temNumber % 10;
                temNumber /= 10;
                int curFactNum = 1;
                for (int i = 1; i <= currNumber; i++)
                {
                    curFactNum *= i;
                }
                factorialSum += curFactNum;
            }
            string result = factorialSum == number ? "yes" : "no";
            Console.WriteLine(result);
        }
    }
}
