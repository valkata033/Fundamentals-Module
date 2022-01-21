using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double pricePerPerson = 0;

            if (dayOfWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 8.45;
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 10.90;
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 9.8;
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 15.60;
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    pricePerPerson = 10.46;
                }
                else if (groupType == "Business")
                {
                    pricePerPerson = 16;
                }
                else if (groupType == "Regular")
                {
                    pricePerPerson = 22.5;
                }
            }

            double allPrice = pricePerPerson * numOfPeople;

            if (groupType == "Students" && numOfPeople >= 30)
            {
                allPrice *= 0.85;
            }
            else if (groupType == "Business" && numOfPeople >= 100)
            {
                allPrice = (numOfPeople - 10) * pricePerPerson;
            }
            else if (groupType == "Regular" && numOfPeople >= 10 && numOfPeople <=20)
            {
                allPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {allPrice:F2}");
        }
    }
}
