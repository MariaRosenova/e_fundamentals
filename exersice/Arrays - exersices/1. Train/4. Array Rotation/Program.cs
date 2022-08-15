using System;
using System.Linq;

namespace _4._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();
            int rotations = int.Parse(Console.ReadLine());
            for (int i = 0 ; i < rotations; i++)   //51 47 32 61 21 -> accepted1
            {
                int temp = arr[0];
                for (int operations = 0; operations < arr.Length-1; operations++)
                {
                    arr[operations] = arr[operations + 1];
                }
                arr[arr.Length-1]=temp;
            }
            Console.WriteLine(string.Join(" ",arr));


        }
    }
}
