using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> items = new Dictionary<string, int>();
            string resources = Console.ReadLine();
            while (resources != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!items.ContainsKey(resources)) // !do you have index with name resourses
                {
                    items[resources] = 0; // items.Add(resourses ,0);                
                }
                items[resources] += quantity;
                    resources = Console.ReadLine();

            }
            foreach (var currResourse in items)
            {
                Console.WriteLine($"{currResourse.Key} -> {currResourse.Value}");
            }
        }
    }
}
