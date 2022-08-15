using System;
using System.Collections.Generic;
using System.Linq;

namespace Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guestDic = new Dictionary<string, List<string>>();
            int count = 0;
            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "Stop")
                {
                    break;
                }
                string[] commandsWithSplit = commands.Split('-');
                string LikeDislike = commandsWithSplit[0];
                string guests = commandsWithSplit[1];
                string meals = commandsWithSplit[2];

                if (LikeDislike == "Like")
                {
                    if (!guestDic.ContainsKey(guests))
                    {
                        guestDic.Add(guests, new List<string>());
                        guestDic[guests].Add(meals);
                    }
                    else
                    {
                        if (!guestDic[guests].Contains(meals))
                        {
                            guestDic[guests].Add(meals);
                        }
                    }
                }
                else if (LikeDislike == "Dislike")
                {
                    if (guestDic.ContainsKey(guests))
                    {
                        if (guestDic[guests].Contains(meals))
                        {
                            guestDic[guests].Remove(meals);
                            count++;
                            Console.WriteLine($"{guests} doesn't like the {meals}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guests} doesn't have the {meals} in his/her collection.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{guests} is not at the party.");
                    }
                }

            }
            foreach (var (guest, listOfMeals) in guestDic.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{guest}: {string.Join(", ", listOfMeals)}");
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }
}