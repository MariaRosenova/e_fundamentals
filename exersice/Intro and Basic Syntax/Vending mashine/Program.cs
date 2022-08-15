using System;
using System.ComponentModel;
using System.Data;

namespace Vending_mashine
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Nuts", "Water", "Crisps", "Soda", "Coke".  2.0, 0.7, 1.5, 0.8, 1.0 
            string command = Console.ReadLine();
            double coins = 0.0; // for sum

            while (command != "Start")
            {
                double coin = double.Parse(command);// -> example for convert 
                if (coin == 0.1 || coin == 0.2 || coin ==0.5 || coin==1 || coin==2 )
                {
                    coins += coin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coin}");
                }
                command = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product!="End")
            {
                switch (product)
                {
                    case "Nuts":
                        if (coins>=2.0)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            coins -= 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Water":
                        if (coins>= 0.7)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            coins -= 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Crisps":
                        if (coins>= 1.5)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            coins -= 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Coke":
                        if (coins>= 1.0)
                        {
                            Console.WriteLine($"Purchased {product.ToLower()}");
                            coins -= 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    case "Soda":
                        if (coins>= 0.8)
                        {

                        Console.WriteLine($"Purchased {product.ToLower()}");
                        coins -= 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {coins:f2}");

        }
    }
}
