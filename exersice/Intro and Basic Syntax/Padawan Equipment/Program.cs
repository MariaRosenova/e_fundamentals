using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfASingleRobe = double.Parse(Console.ReadLine());
            double priceOfASingleBelt = double.Parse(Console.ReadLine());
            //buy 10% more (taken from the student's count), rounded up to the next integer. Also, every sixth belt is free. 

            
            double numOfLightsabers = Math.Ceiling(countOfStudents* 1.10);
            double finalPriceForSabers = priceOfLightsabers * numOfLightsabers;
            double numFreeBelts = Math.Floor(countOfStudents / 6.0);
            double priceBelts = countOfStudents- ( numFreeBelts * priceOfASingleBelt);
            double numOfRobes = countOfStudents * priceOfASingleRobe;
            double total = finalPriceForSabers + priceBelts + numOfRobes;

            if (total>=amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                double neededMoney = Math.Abs(amountOfMoney - total);
                Console.WriteLine($"Ivan Cho will need {neededMoney:f2}lv more.");
            }
;


        }
    }
}
