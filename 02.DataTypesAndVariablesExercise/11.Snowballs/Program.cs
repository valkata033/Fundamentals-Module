using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger highestValue = 0;

            int largestSnow = 0;
            int largestTime = 0;
            int largestQuality = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if (snowballValue > highestValue)
                {
                    highestValue = snowballValue;
                    largestSnow = snowballSnow;
                    largestTime = snowballTime;
                    largestQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{largestSnow} : {largestTime} = {highestValue} ({largestQuality})");
        }
    }
}
