using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.Burger_Bus
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            double income, expenses, profit,free = 0.0;
            int towns = int.Parse(Console.ReadLine());
            int count = 0;
            double[] array = new double[towns];
            List<double> profitMoney = new List<double>();
            List<string> namesOfTowns = new List<string>();
            List<string> profitMoneyForTotal = new List<string>();


            for (int i = 1; i <= towns; i++)
            {
                count++;
                name = Console.ReadLine();
                namesOfTowns.Add(name);
                income = double.Parse(Console.ReadLine());
                expenses = double.Parse(Console.ReadLine());


                if (count == 3)
                {
                    profit = income - expenses;
                    expenses /= 2;
                    profit =profit - expenses;
                    free = Math.Round(profit, 3);
                    profitMoney.Add(free);
                    
                }
                else if (count == 5)
                {
                    profit = income - expenses;
                    profit = profit - (profit * 0.10);
                    //decimal dc = Math.Round(d, 2);
                    free = Math.Round(profit, 3);

                    profitMoney.Add(free);
                }
                else
                {
                    profit = income - expenses;
                    free = Math.Round(profit, 3);
                    profitMoney.Add(free);
                }

            }
            double totalMoneySum = 0;
            for (int i = 0; i < profitMoney.Count; i++)
            {
                totalMoneySum += profitMoney[i];
            }
            //convert
            string[] arrayString = new string[towns];
            for (int i = 0; i <= profitMoney.Count-1; i++)
            {
                arrayString[i] = (profitMoney[i].ToString());
            }

            //print
            for (int i = 0; i <= namesOfTowns.Count; i++)
            {
                for (int k = i; k <= arrayString.Length-1; k++)
                {
                    Console.WriteLine($"In {namesOfTowns[i]} Burger Bus earned {arrayString[i]} leva.");
                    break;
                }
            }

            Console.WriteLine($"Burger Bus total profit: {totalMoneySum:f2} leva.");

        }






    }
}
