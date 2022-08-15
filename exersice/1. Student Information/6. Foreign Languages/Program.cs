using System;
using System.Runtime.InteropServices.ComTypes;

namespace _6._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	English is spoken in England and the USA.
            //•	Spanish is spoken in Spain, Argentina, and Mexico.
            //•	For the others, we should print "unknown".
            string country = Console.ReadLine();
            if (country== "England")
            {
                Console.WriteLine("English");
            }
            else if (country=="USA")
            {
                Console.WriteLine("English");
            }
            else if (country== "Spain")
            {
                Console.WriteLine("Spanish");
            }
            else if (country == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else if (country == "Mexico")
            {
                Console.WriteLine("Spanish");
            }
            else
            {
                Console.WriteLine("unknown");
            }

        }
    }
}
