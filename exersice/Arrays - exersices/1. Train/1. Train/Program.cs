using System;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int[] wagons = new int[input];
            int sum = 0;
            for (int i = 0; i <= wagons.Length-1; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum += wagons[i];
            }
            foreach (int numbers in wagons)
            {
                Console.Write(numbers + " ");
            }
            Console.WriteLine();
            if (input > 1) Console.WriteLine(sum);
            







        }
    }
}
