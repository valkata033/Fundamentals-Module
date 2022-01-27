using System;
using System.Linq;

namespace _09.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            int maxSequence = 0;
            int currentSequence = 1;
            string element = String.Empty;
            int mostLeftIndex = 0;

            while (command != "Clone them!")
            {
                int[] numbers = command.Split("!").Select(int.Parse).ToArray();

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        currentSequence++;
                    }
                    else
                    {
                        currentSequence = 1;
                    }

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                }
                command = Console.ReadLine();
            }

        }
    }
}
