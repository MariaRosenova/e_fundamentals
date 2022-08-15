using System;
using System.Linq;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            BiggerNumber(firstNumber, secondNumber, thirdNumber);
        }
        static void BiggerNumber(int first, int second, int third)
        {

            int[] array1 = { first, second, third };

            // Find maximum number.
            Console.WriteLine(array1.Min());


        }
    }
}
