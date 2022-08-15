using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfData = Console.ReadLine();
            switch (typeOfData)
            {
                case "string":
                    string line = Console.ReadLine();
                    PrintString(line);
                    break;
                case "int":
                    int inputSecond = int.Parse(Console.ReadLine());
                    PrintInteger(inputSecond);
                    break;
                case "real":
                    double input = double.Parse(Console.ReadLine());
                    PrintDouble(input);
                    break;
            }

        }
        static void PrintInteger(int input )
        {
             
             input *=2;
             Console.WriteLine(input);
        }
        static void PrintDouble(double input)
        {
            
            input *= 1.5 ;
            
            Console.WriteLine($"{ input:f2}");
        }
        static void PrintString(string input)
        {
            Console.WriteLine($"${input}$");
        }
    }
}
