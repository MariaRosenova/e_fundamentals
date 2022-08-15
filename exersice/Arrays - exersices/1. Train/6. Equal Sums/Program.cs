using System;
using System.Linq;

namespace _6._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i <= numbers.Length-1; i++)
            {
                if (numbers.Length==1)
                {
                    Console.WriteLine(0);
                    return;
                }
                //leftSum 
                leftSum = 0;
                for (int sumLeft = i; sumLeft >0; sumLeft--)
                {
                    int nextElementPosition = sumLeft - 1;
                    if (sumLeft>0)
                    {
                        leftSum += numbers[nextElementPosition];
                    }
                }
                //rightSum
                rightSum = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    int nextElementPosition = (j + 1);
                    if (j<numbers.Length-1)
                    {
                        rightSum += numbers[nextElementPosition];
                    }
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");


            
        }
    }
}
