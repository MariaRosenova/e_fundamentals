using System;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int theInteger2 = int.Parse(Console.ReadLine());
            int product = 0;
            if (theInteger2 > 10)
            {
                ////{theInteger} X {times} = {product}
                product = theInteger * theInteger2;
                Console.WriteLine($"{theInteger} X {theInteger2} = {product}");
            }
            else
            {
                for (int times = theInteger2; times <= 10; times++)
                {
                    product = theInteger * times;
                    Console.WriteLine($"{theInteger} X {times} = {product}");
                    //{theInteger} X {times} = {product}
                }

            }
        }
    }
}
