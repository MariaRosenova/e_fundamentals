using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrOne = Console.ReadLine().Split(" ");
            string[] arrTwo = Console.ReadLine().Split(" ");
            foreach (string elementsOne in arrOne)
            {
                foreach (string elementsTwo in arrTwo)
                {
                    if (elementsTwo == elementsOne)
                    {
                        Console.Write(elementsOne + " ");
                        break;
                    }
                }
            }
        }
    }
}
