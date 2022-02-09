using System;
using System.Text.RegularExpressions;

namespace _03.SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|([0-9]{1,})\|[^|$%.]*?([0-9]+(\.[0-9]+)?)\$$";

            double totalPrice = 0;
            double totalIncome = 0;

            string input = Console.ReadLine();

            while (input != "end of shift")
            {
                Match match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                string customerName = match.Groups[1].Value;
                string product = match.Groups[2].Value;
                double count = double.Parse(match.Groups[3].Value);
                double price = double.Parse(match.Groups[4].Value);

                totalPrice = count * price;
                totalIncome += totalPrice;

                Console.WriteLine($"{customerName}: {product} - {totalPrice:F2}");
                

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}
