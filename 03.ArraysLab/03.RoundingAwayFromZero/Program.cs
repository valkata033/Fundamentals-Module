﻿using System;
using System.Linq;

namespace _03.RoundingAwayFromZero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split()
                .Select(double.Parse).ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = 0;
                }

                int rounded = (int) Math.Round(array[i],
                    MidpointRounding.AwayFromZero);
                Console.WriteLine($"{array[i]} => {rounded}");
            }

        }
    }
}
