using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double moneyNeeded = (priceOfLightsabers * Math.Ceiling(countOfStudents * 1.1)) +
                                 (priceOfRobes * countOfStudents) +
                                 (priceOfBelts * (countOfStudents - (countOfStudents / 6)));

            if (moneyNeeded <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {moneyNeeded:F2}lv.");
            }

            else
            {
                Console.WriteLine($"John will need {moneyNeeded - amountOfMoney:F2}lv more.");
            }
           
        }
    }
}
