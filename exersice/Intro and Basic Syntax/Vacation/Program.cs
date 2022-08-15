using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
                    //Friday   Saturday    Sunday
             //Students    8.45    9.80    10.46
             //Business    10.90   15.60    16
             // Regular     15      20     22.50

            //•	Students – if the group is bigger than or equal to 30 people you should reduce the total price by 15 %
            // •Business – if the group is bigger than or equal to 100 people 10 of them can stay for free.
             // •Regular – if the group is bigger than or equal to 10 and less than or equal to 20 reduce the total price by 5 %


            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice=0;
            double ticket = 0;

            switch (dayOfWeek)
            {
                case "Friday":
                    if (typeOfGroup == "Students")
                    {
                        if (countOfPeople>=30)
                        {
                            ticket = 8.45;
                            totalPrice= (countOfPeople * ticket) - (countOfPeople*ticket * 0.15);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 8.45;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else if (typeOfGroup=="Business")
                    {
                        if (countOfPeople >= 100)
                        {
                            ticket = 0;
                            totalPrice = 0;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 10.90;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else if (typeOfGroup=="Regular")
                    {
                        if (countOfPeople >= 10)
                        {
                            ticket = 15;
                            totalPrice = (countOfPeople * ticket) - (countOfPeople*ticket * 0.05);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 15;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    break;
                   case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        if (countOfPeople >= 30)
                        {
                            ticket = 9.80;
                            totalPrice = (countOfPeople * ticket) - (countOfPeople * ticket * 0.15);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 9.80;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else if (typeOfGroup == "Business")
                    {
                        if (countOfPeople >= 100)
                        {
                            ticket = 0;
                            totalPrice = 0;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 15.60;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        if (countOfPeople >= 10 && countOfPeople>=20)
                        {
                            ticket = 20;
                            totalPrice = (countOfPeople * ticket) - (countOfPeople * ticket* 0.05);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 20;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    break;
                case "Sunday":
                    if (typeOfGroup == "Students")
                    {
                        if (countOfPeople >= 30)
                        {
                            ticket = 10.46;
                            totalPrice = (countOfPeople * ticket) -(countOfPeople*ticket* 0.15);
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 10.46;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else if (typeOfGroup == "Business")
                    {
                        if (countOfPeople >= 100)
                        {
                            ticket = 0;
                            totalPrice = 0;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 16;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        if (countOfPeople >= 10)
                        {
                            ticket = 22.50;
                            totalPrice = (countOfPeople * ticket)* 0.05;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                        else
                        {
                            ticket = 22.50;
                            totalPrice = countOfPeople * ticket;
                            Console.WriteLine($"Total price: {totalPrice:f2}");
                        }
                    }
                    break;
            }

        }
    }
}
