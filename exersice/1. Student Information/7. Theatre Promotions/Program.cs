using System;

namespace _7._Theatre_Promotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0;
            switch (typeOfDay)
            {
                case "Weekday":
                    if (0<=age &&  age<= 18)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 18;
                        Console.WriteLine($"{price}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");
                    }
                    break;
                case "Weekend":
                    if (0 <= age && age <= 18)
                    {
                        price = 15;
                        Console.WriteLine($"{price}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 20;
                        Console.WriteLine($"{price}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        price = 15;
                        Console.WriteLine($"{price}$");
                    }
                    break;
                case "Holiday":
                    if (0 <= age && age <= 18)
                    {
                        price = 5;
                        Console.WriteLine($"{price}$");
                    }
                    else if (18 < age && age <= 64)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (64 < age && age <= 122)
                    {
                        price = 10;
                        Console.WriteLine($"{price}$");
                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                    break;

            }
            

        }
    }
}
