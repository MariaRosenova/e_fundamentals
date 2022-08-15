using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	The first number is hours and will be between 0 and 23.
            //•	The second number is minutes and will be between 0 and 59.
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 30;
            if (min >= 60)
            {
                hour += 1;
                min -=60;

                if (hour >= 24)
                {
                    hour = 0;
                }
            }
            //24

            Console.WriteLine($"{hour}:{min:d2}");


        }
    }
}
