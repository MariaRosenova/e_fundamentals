using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            var legendaryItem = new Dictionary<string, int>();
            var junkMaterials = new Dictionary<string, int>();
            bool isLegendaryFound = false;
            while (!isLegendaryFound)
            {
                string[] input = Console.ReadLine().Split();
                for (int i =1; i < input.Length; i+=2)
                {
                    string keyMaterial = input[i].ToLower();
                    int valueMaterial = int.Parse(input[i - 1]);
                    if (keyMaterial=="shards"||keyMaterial=="motes"|| keyMaterial=="fragments")
                    {
                        if (!legendaryItem.ContainsKey(keyMaterial))
                        {
                            legendaryItem[keyMaterial] = 0;
                        }
                        legendaryItem[keyMaterial] += valueMaterial; //legendaryItems.add(keyMaterial,valueMaterial)
                        if (legendaryItem[keyMaterial]>=250)
                        {
                            isLegendaryFound = true;
                            break;
                        }
                    }
                    else if (junkMaterials.ContainsKey(keyMaterial))
                    {
                        junkMaterials[keyMaterial] +=valueMaterial;
                    }
                    else
                    {
                        junkMaterials.Add(keyMaterial, valueMaterial);
                    }

                }

            }
            if (legendaryItem["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                legendaryItem["shards"] -= 250;
            }
            else if (legendaryItem.ContainsKey("fragments") && legendaryItem["fragments"]>=250)
            {
                Console.WriteLine("Valanyr obtained!");
                legendaryItem["fragments"] -= 250;
            }
             else if (legendaryItem.ContainsKey("motes") && legendaryItem["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                legendaryItem["motes"] -= 250;
            }
            foreach (var keyItems in legendaryItem.OrderByDescending(key=>key.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{keyItems.Key}: {keyItems.Value}");
            }
            foreach (var junkItem in junkMaterials.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }
    }
}
