using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string largestKeg = string.Empty;
            double largestVolume = 0;

            for (int i = 0; i < n; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume > largestVolume)
                {
                    largestVolume = kegVolume;
                    largestKeg = kegName;
                }
            }

            Console.WriteLine(largestKeg);
        }
    }
}
